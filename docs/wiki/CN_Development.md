本文提供一些进一步对 Protoshift 进行定制的指南，以及对于特殊日志进行输出的注解。

# 高级开发

- [Packet Notify 中间件](#packet-notify-中间件)
- [ProxyOnly 模式注解](#proxyonly-模式注解)
- [`latest.packet.log` 注解](#latestpacketlog-注解)
- [`latest.player.stat.log` 注解](#latestplayerstatlog-注解)
- [OrderedPacket 策略](#orderedpacket-策略)
- [自行搭建 Protos 远程存储库](#自行搭建-protos-远程存储库)

## Packet Notify 中间件

在 `csharp-Protoshift/GameSession/PacketNotify` 下为 Packet Notify 系统的主要实现。有关 Packet Notify 的具体信息，此处引用 [PR #28: Standard Notify middleware for HandlerSession](https://github.com/YYHEggEgg/csharp-Protoshift/pull/28) 的描述：

> The PacketNotify system is used to register notify callbacks every time the specified packet arrived the Protoshift server. Usually the callback will be called after packet is Protoshifted, but the provided paramters is the original packet (as is from remote).

简单来说，它开放一个中间件，让外部代码获知包的信息并作出相应行动。

如果想要自行添加一个中间件，可以进行以下步骤：

- 在 `csharp-Protoshift/GameSession/PacketNotify` 下创建一个单独的文件，如 `HandlerSession.Notify.[Usage].cs`. 复制以下的模板：

```cs
namespace csharp_Protoshift.GameSession
{
    public partial class HandlerSession
    {
        private void [PacketName]Notify(byte[] packet, int offset, int length)
        {
            // Your stuff...
        }
    }
}
```

你的代码将成为类 `HandlerSession` 的一部分。建议您将方法命名为 [Packet 名称]+`Notify`。

编写方法后，您需要使其生效。打开 `csharp-Protoshift/GameSession/PacketNotify/HandlerSession.PacketNotifyDispatch.cs`，修改 `ConfigureInitialNotifyList` 方法：

```cs
private void ConfigureInitialNotifyList()
{
    PushNotifyStatus("GetPlayerTokenReq", false, true, GetPlayerTokenReqNotify);
    PushNotifyStatus("GetPlayerTokenRsp", true, false, GetPlayerTokenRspNotify);
}
```

在下面添加一行类似的代码，使你的方法生效。

第一个 bool 值指定是否将其用于服务端发的包，第二个指定是否将其用于客户端的包。特别的，**你不能为两个值都指定 true**，因为两边发来的包的 Proto 不同（尽管其名称相同）。

## ProxyOnly 模式注解

在 `csharp-Protoshift/csharp-Protoshift.csproj` 中，您可以看到 `DefinConstants` 中已经定义了 `PROXY_ONLY_SERVER_DISABLED` 符号；

```xml
  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
    <DefineConstants>$(DefineConstants);PROXY_ONLY_SERVER_DISABLED</DefineConstants>
  </PropertyGroup>

  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
    <DefineConstants>$(DefineConstants);PROXY_ONLY_SERVER_DISABLED</DefineConstants>
  </PropertyGroup>
```

如果您去掉 `_DISABLED` 而定义 `PROXY_ONLY_SERVER`，则可以启用 ProxyOnly 服务器选项。

ProxyOnly 的具体逻辑在 `csharp-Protoshift/GameSession/ProxyOnly` 中实现。它的作用是，并不进行 Protoshift 流程，将包按原样在服务端与客户端间传递，并将信息记录到日志中。

综上所述，在使用 ProxyOnly 模式时，**服务端与客户端必须使用完全相同的 Protocol**。它不需要手动在构建时指定两套相同的 Protocol 分支；它以供服务端使用的 Protocol 分支（`OldProtos`）为准。

它的设计本意是观测网络协议栈在实践场景下的表现。但正如 [Wiki - Resources - `rsakeys` 文件夹](CN_Resources#rsakeys-文件夹) 中所提到的，由于您需要服务端私钥才能运行本代理服务器，您不能使用 ProxyOnly 实现作为那些您不具有控制权的服务器的代理抓包软件。

在 ProxyOnly 模式下，`latest.packet.log` 的格式有所不同。有关详细信息，请参阅 [`latest.packet.log` 注解](#latestpacketlog-注解)。

## `latest.packet.log` 注解

该日志文件记录了曾经过 Protoshift 代理服务器的所有包 - 除非它们被排除。您可以在 `config.json` 中定义 `PacketLogExcluding` 来在 `latest.packet.log` 中进行排除。

该日志文件没有表头。通常情况下，其是一个竖线分隔值文件，格式如下：

```log
[time]|Info|[uid]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]|[handleNanoseconds]|[shiftedData]
```

各项参数意义如下：

- `time` 为包被记录的时间。
- 第二项为日志的级别。在 `latest.packet.log` 中，它固定为 `Info`；`GameSessionDispatch.PacketLogger` 同样丢弃级别非 `Information` 的所有日志。
- 第三项为 UID. 特别的，在 UID 未确认的情况下（如刚刚收到 `GetPlayerTokenReq`），它的值固定为 0.
- `PacketName` 为从 `CmdId` 翻译而来的 Proto Message 名称。
- `CmdId` 为传入包的 `cmdid`。
- `sentByClient` 指示它由客户端（`true`）或服务端（`false`）发出。
- `head` 是 Proto 为 `PacketHead.proto` 的包头。
- `body` 是包的主体。
- `handleNanoseconds` 为使用 `Stopwatch` 记录的，从包被传入到返回可供发送的完整包所用的全部时间。
- `shiftedData` 为经过 Protoshift 后的 **`body` 结果**。

在 Protoshift 完成后，包记录很快就会被输出到 `latest.packet.log` 中。

如果正在使用 ProxyOnly 模式，则不会附带 `handleNanoseconds` 与 `shiftedData`. 有关 ProxyOnly 模式的详细信息，请参阅 [ProxyOnly 模式注解](#proxyonly-模式注解).

## `latest.player.stat.log` 注解

为了减少控制台端的输出量（并标准化信息日志记录），一些相关的信息被迁移至了 `latest.player.stat.log` 中。

它具有表头，其表头如下：

```log
[time]|Info|Conv ID|UID|Status category|Description|--[Any other Data]--
```

注意到此处同时输出 `Conv ID` 与 `UID`. 有关其区别，请参见 [Wiki - Commands - 代理服务控制命令](CN_Commands#代理服务控制命令).

接下来将会根据 `Status category` 列出输出的主要格式。

- [Category: `kcp`](#category-kcp)
  - [`kcp|connect` 消息](#kcpconnect-消息)
  - [`kcp|disconnect` 消息](#kcpdisconnect-消息)
- [Category: `rsa_seed_exchange`](#category-rsa_seed_exchange)
- [Category: `handler`](#category-handler)
  - [`too_long_timecost` 消息](#too_long_timecost-消息)
- [Category: `skill_issue_detect(async)`](#category-skill_issue_detectasync)

### Category: `kcp`

`kcp` 的状态目前仅涉及两种：`connect` 与 `disconnect`.

KCP 实现涉及多个不同的模块，而它们之间的信息共享度较低。因此，信息通常以变量的形式给出，每种消息会提供的值都不尽相同。

以下是可能会出现的值：

- `token={kcp_token}`. 这是客户端与服务端之间确认 KCP 包文有效性的 Token，是一个随机生成的 32 位无符号整数。它是一个连接参数，意味着在连接结束后即刻失去意义。
- `ip={remote.ip:port}`. 客户端的 IP（带有端口号），仅在 `kcp|connect` 消息中提供。
- `reason={ENetReason_id}`. 此为**断开连接**时，KCP Handshake 包中的 `data` 参数。仅在 `kcp|disconnect` 消息中提供。

#### `kcp|connect` 消息

该消息提供连接的 `token` 与客户端的 `ip`. 样例如下：

```log
Info|1001|0|kcp|connect|token=2545132343|ip=127.0.0.1:23456
```

#### `kcp|disconnect` 消息

该消息的 `Any other data` 部分并不全是值；它的第一项是发起断开连接请求者的身份。将会出现以下身份：

- `from_client`: 客户端请求断开了连接。一般而言，在客户端断开连接后，服务端会就此进行回复，因此下面常有身份为 `from_server` 的信息。
- `from_server`: 服务端主动断开了连接。
- `proxy_kick(client)`: 中间代理层（本服务器）要求客户端中止会话。原因可能有 `kick` 命令或正在关闭 Protoshift 代理服务器；由于作为代理需要向两方断开连接，因此有 `proxy_kick(client)` 与 `proxy_kick(server)` 两种身份，分别标明发送到客户端与服务端的 KCP Handshake 信息。
- `proxy_kick(server)`: 中间代理层（本服务器）要求服务端中止会话。其他说明已在上面给出，不过需要强调的是，作为代理层切断连接时，通常发送到客户端与服务端的 reason 是不相同的。

以下是一个样例：

```log
Info|1001|0|kcp|disconnect|from_server|token=2545132343|reason=0
```

### Category: `rsa_seed_exchange`

RSA Seed Exchange 是某二游用以确保连接安全性的工具。建议您阅读 `sdl.moe` 上的 [相关文章](https://sdl.moe/post/magic-sniffer/) 来对下面的内容有一些了解。

`rsa_seed_exchange` 有四种消息：

- `client_seed`: 在客户端发送 `GetPlayerTokenReq` 时确认。
- `server_seed`: 在服务端回复 `GetPlayerTokenRsp` 时获取。
- `final_seed`: 是 `client_seed` 与 `server_seed` 的异或结果，但不同于前两者，它是数字形式。
- `new_xorkey`: 通过 `final_seed` 生成的最终异或密钥，用于接下来的通信全过程。

其中：

- `client_seed` 与 `server_seed` 消息后第一个值是 `succ` 或 `fail`. 如果成功，则会将解密获得的 `client_seed` 或 `server_seed` 内容以**十六进制**输出在后面。
- `final_seed` 后第一个值目前固定是 `succ`，将 `client_seed` 与 `server_seed` 的异或结果以**数字形式**输出在后面。
- `new_xorkey` 仅输出十六进制的异或密钥。

### Category: `handler`

目前 `handler` 类别下仅有 `too_long_timecost` 消息。

#### `too_long_timecost` 消息

其记录 Protoshift 过程花费过长时间。目前，“过长时间”的定义是处理耗时超过 15ms. 以下是一个样例：

```log
Info|1001|10000|handler|too_long_timecost|GetPlayerTokenReq|231ms
```

该报告策略仅对严格有序的包生效。有关有序包的信息，请参阅 [OrderedPacket 策略](#orderedpacket-策略)。

### Category: `skill_issue_detect(async)`

在 Protoshift 完成后，包将会交予 `SkillIssueDetect` 的后台线程，对包进行分析以确认是否有字段在 Protoshift 过程中丢失。

目前，该判断的策略是将 Protoshift 前后的包分别序列化为 JSON，并比对 JSON 的行数。未来可能会有更智能的判断策略。

以下是一个样例：

```log
Warn|1001|10000|skill_issue_detect(async)|PingRsp|old|{"retcode":0}
Warn|1001|10000|skill_issue_detect(async)|PingRsp|new|{}
```

## OrderedPacket 策略

由于一些特殊的原因，某二游要求一些包必须有序传输，否则可能会引发未知的问题。

在本 Protoshift 的开发过程中，早期处理该问题时采用过异步处理、队列同步的模式，但由于实践中较差的性能而被放弃。现在，对于强有序的包而言，**必须等上一个处理完并发出后才会开始处理下一个**。

目前 Protoshift 采用的是 `unordered` 策略，即除了小部分包其他包都是强有序处理的。你可以通过更改 `csharp-Protoshift/GameSession/Protoshift/HandlerSession.Protoshift.cs` 中的 `List<string> unordered_messages` 来改变哪些包允许在后台进行处理并无序传输。

## 自行搭建 Protos 远程 Git 存储库

目前供一般用户使用的 Proto 存储库是我们的 [mihomo-protos](https://github.com/YYHEggEgg/mihomo-protos). 

显然，最简单的方式便是直接复刻该仓库，并在此基础上进行修改。如果这样，你只需要注意 `protostat.json` 的格式：

```json
{
    "$schema": "protostat_schema.json",
    "CurrentStat": "Valid",
    "ReleaseTime": "2023-10-23T06:12:00+00:00"
}
```

`ReleaseTime` 用于标明 `Proto` 的版本，其实际上仅用于与其他分发版本进行同步，Proto 更新本身仅取决于 Git 拉取。如果该仓库永不设置 `RedirectUrl`，则可以不更改任何值。

接下来介绍可供 csharp-Protoshift 使用的 Proto 仓库格式：

- `Protos` 内包含所有目标 Proto. 尽量保证其中不存在子目录，否则可能引发未知问题。
- `cmdid.csv` 中包含 Proto 名称与 CmdId 的对应关系。不存在表头，仅有两列，分别为名称与数字。
- 如果供您或您的组织内部使用，`ThirdPartyLicenses` 不是必需的。`compileprotos` 等脚本同理。
- 至少保留一个 `protostat.json`，其中须指明 `CurrentStat` 为 `Valid`。
- 采用以下 `.gitignore` 文件：

  ```ignore
  /Compiled
  /Proto2json_Output
  ```

- 分支名就是 Proto 版本的标识。如果您像 `mihomo-protos` 一样有一个作为基而不存放实际 Proto 的主分支，建议您将其 `protostat.json` 中 `CurrentStat` 设为 `Deprecated`.

搭建自己的 Proto Git 远程存储库后，您可能需要使您的合作者使用新的源或变更分支。有关详细信息，请参阅 [Wiki - Building - Proto 远程抓取管理](CN_Building#proto-远程抓取管理)。
