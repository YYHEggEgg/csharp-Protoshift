This page provides some tutorials about advanced DIY options for Protoshift, and some comments about special logging outputs.

# Advanced Development

- [Packet Notify Middleware](#packet-notify-middleware)
- [ProxyOnly Mode Annoations](#proxyonly-mode-annoations)
- [`latest.packet.log` Annoations](#latestpacketlog-annoations)
- [`latest.player.stat.log` Annoations](#latestplayerstatlog-annoations)
- [OrderPacket Policy](#orderpacket-policy)
- [Building Your Own Protos Remote Git Repository](#building-your-own-protos-remote-git-repository)

## Packet Notify Middleware

There're the implemention of Packet Norify System under `csharp-Protoshift/GameSession/PacketNotify`. Here's refering to the description in [PR #28: Standard Notify middleware for HandlerSession](https://github.com/YYHEggEgg/csharp-Protoshift/pull/28) to clarify what Packet Notify is:

> The PacketNotify system is used to register notify callbacks every time the specified packet arrived the Protoshift server. Usually the callback will be called after packet is Protoshifted, but the provided paramters is the original packet (as is from remote).

In short, it exports a middleware, enabling the outer code to know the information of a packet and take the corresponding actions.

If you want to add a middleware yourself, you may perform the following steps:

- Create a single file under `csharp-Protoshift/GameSession/PacketNotify` like `HandlerSession.Notify.[Usage].cs`. Copy the following model:

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

You code will be a part of class `HandlerSession`. You're recommended to name the method as [Packet Name]+`Notify`.

After writing the method body, you need to make it in effect. Open file `csharp-Protoshift/GameSession/PacketNotify/HandlerSession.PacketNotifyDispatch.cs` and modify method `ConfigureInitialNotifyList`:

```cs
private void ConfigureInitialNotifyList()
{
    PushNotifyStatus("GetPlayerTokenReq", false, true, GetPlayerTokenReqNotify);
    PushNotifyStatus("GetPlayerTokenRsp", true, false, GetPlayerTokenRspNotify);
}
```

Add a similar line to make your method in effect.

The first boolean value indicate whether to use it for packets sent by the server, and the second one indicate whether to use it for packets sent by the client. Specially, **you can't provide both paramters with true**, because the packet from two sides uses a different Proto (even if they share the same name).

## ProxyOnly Mode Annoations

Take a look into `csharp-Protoshift/csharp-Protoshift.csproj`, and you'll see `PROXY_ONLY_SERVER_DISABLED` symbol defined in `DefinConstants`:

```xml
  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Debug|AnyCPU'">
    <DefineConstants>$(DefineConstants);PROXY_ONLY_SERVER_DISABLED</DefineConstants>
  </PropertyGroup>

  <PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
    <DefineConstants>$(DefineConstants);PROXY_ONLY_SERVER_DISABLED</DefineConstants>
  </PropertyGroup>
```

If you split out `_DISABLED` to make `PROXY_ONLY_SERVER` defined, the ProxyOnly Server option is enabled.

`csharp-Protoshift/GameSession/ProxyOnly` has the concrete implemention of ProxyOnly. It actually don't perform a Protoshift process and transfer the packet between the server and the client as it is, recording the content into the packet log.

In conclusion, when using ProxyOnly Mode, **the server should be using the same Protocol as the client**. It don't need to manually specify two equal Protocol branch in building with HandlerGenerator; it uses the Protocol branch for the server, or the `OldProtos`.

It was designed to observe the implemention of the Network Protocol Stack in practice. But as is mentioned in [Wiki - Resources - `rsakeys` Folder](EN_Resources#rsakeys-folder),  because you need the `ServerPri` key to run the proxy server, you cannot use this Protoshift implementation as a proxy capture software for servers that you do not control.

The format of `latest.packet.log` is different if you're in the ProxyOnly Mode. For more information, please refer to [`latest.packet.log` Annoations](#latestpacketlog-annoations).

## `latest.packet.log` Annoations

This log file records all packets that passed by the Protoshift proxy server - unless they are filtered. You can change the definition of `PacketLogExcluding` in `config.json` to set the filter for `latest.packet.log`.

The log file don't have a header. In common, this is a Pipeline Separator File, and this is it's format:

```log
[time]|Info|[uid]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]|[handleNanoseconds]|[shiftedData]
```

The meaning of values is showed following:

- `time` is the recorded time of the packet.
- The second value is the level of the log. It is always `Info` in `latest.packet.log`; `GameSessionDispatch.PacketLogger` also drops all long with log level other than `Information`.
- The third value is UID. Specially, when the UID isn't gotten (e.g. in the `GetPlayerTokenReq` parse), it's value will always be 0.
- `PacketName` is the Proto Message name translated from `CmdId`.
- `CmdId` is as is given `cmdid`.
- `head` is the packet head, whose Proto is `PacketHead.proto`.
- `body` is the main body of the packet.
- `handleNanoseconds` is the total interval from starting handling the packet to returning a full packet that can be sent directly. It's recorded by `Stopwatch`.
- `shiftedData` is the **`body` result** after Protoshifted.

After finished Protoshift, the packet record will be sooned output into `latest.packet.log`.

If you're current using ProxyOnly Mode, the `handleNanoseconds` and `shiftedData` will not be included. For more information about ProxyOnly Mode, please refer to [ProxyOnly Mode Annoations](#proxyonly-mode-annoations).

## `latest.player.stat.log` Annoations

To reduce the output amount of the Console (and standardlize some logging about online information), some related information is moved into `latest.player.stat.log`.

It has a header:

```log
[time]|Info|Conv ID|UID|Status category|Description|--[Any other Data]--
```

Notice that `Conv ID` and `UID` are both output here. For information about their difference, please refer to [Wiki - Commands - Proxy Service Control Commands](EN_Commands#proxy-service-control-commands).

The main output formats will be listed below according to their `Status category`:

- [Category: `kcp`](#category-kcp)
  - [`kcp|connect` message](#kcpconnect-message)
  - [`kcp|disconnect` message](#kcpdisconnect-message)
- [Category: `rsa_seed_exchange`](#category-rsa_seed_exchange)
- [Category: `handler`](#category-handler)
  - [`too_long_timecost` message](#too_long_timecost-message)
- [Category: `skill_issue_detect(async)`](#category-skill_issue_detectasync)

### Category: `kcp`

There are two types of related status of `kcp` currently: `connect` and `disconnect`.

The KCP implemention is related to multiple different modules, which don't share much information. Therefor, the information is provided with a variable format, and different messages provide different values.

The following shows possible values:

- `token={kcp_token}`. This token is used to validate the KCP packet, which is a random generated unsigned 32-bit integer. It's a connect param, and it becomes meaningless as soon as the connection is down.
- `ip={remote.ip:port}`. The client's IP (with port). Only provided in `kcp|connect` messages.
- `reason={ENetReason_id}`. This is the `data` param in KCP Handshake packet when **disconnecting**. Only provided in `kcp|disconnect` messages.

#### `kcp|connect` message

This message provide the connection `token` and the client's `ip`. Here's an example:

```log
Info|1001|0|kcp|connect|token=2545132343|ip=127.0.0.1:23456
```

#### `kcp|disconnect` message

The `Any other data` part of the message is not all values; its first column is who sent the disconnect request. The following identity can be seen:

- `from_client`: The client requested to disconnect gracefully. Generally, the server will reply after the client requested disconnect, so a message with `from_server` identity is expected to appear below.
- `from_server`: The server disconnected.
- `proxy_kick(client)`: The middle proxy (this proxy server) is demanding the client to stop the session. The reason maybe a  `kick` command attmpt or the Protoshift proxy server is shuting down; because the proxy need to disconnect from the both sides, there're `proxy_kick(client)` and `proxy_kick(server)`, the two identitys, which specify the KCP Handshake message sent to client or server.
- `proxy_kick(server)`: The middle proxy (this proxy server) is demanding the server to stop the session. Other descriptions are provided below, but what need to be emphasized is that the reason sent to client and server are usually not equal when the proxy is cutting down the connection.

Here's an example:

```log
Info|1001|0|kcp|disconnect|from_server|token=2545132343|reason=0
```

### Category: `rsa_seed_exchange`

A certain anime game uses RSA Seed Exchange to ensure the connection safety. You are recommended to read a [related post](https://sdl.moe/post/magic-sniffer/) on `sdl.moe` to gain some knowledge of the content below.

There're 4 messages of `rsa_seed_exchange`:

- `client_seed`: Get when the client sent `GetPlayerTokenReq`.
- `server_seed`: Get when the server sent `GetPlayerTokenRsp`.
- `final_seed`: The XOR result of `client_seed` and `server_seed`, but it's in numberic format.
- `new_xorkey`: The final XOR Key generated by `final_seed`, which will be used in the whole session.

In these messages:

- The first value after `client_seed` and `server_seed` message is `succ` or `fail`. If it succeeded, the content of `client_seed` or `server_seed` will be followed in **HEX format**.
- The first value after `final_seed` is always `succ` currently. ，The XOR result of `client_seed` and `server_seed` will be followed in **numberic format**.
- `new_xorkey` is the HEX XOR Key.

### Category: `handler`

There's only `too_long_timecost` message under the `handler` category.

#### `too_long_timecost` message

It creates a recird when the Protoshift process costed too much time. Currently, the definition of "too long time" is >= 15ms. Here's an example:

```log
Info|1001|10000|handler|too_long_timecost|GetPlayerTokenReq|231ms
```

This reporting policy only applies to strictly ordered packet. For more information about ordered packet, please refer to [OrderPacket Policy](#orderpacket-policy).

### Category: `skill_issue_detect(async)`

After Protoshift finished, the packet will be handed to the background thread of `SkillIssueDetect` to analyze the packet and see whether there're any fields lost in Protoshift process.

Currently, the judge policy is serialize the packet before and after Protoshift into JSON, then compare their lines count. There may be a smarter judge policy in the future.

Here's an example:

```log
Warn|1001|10000|skill_issue_detect(async)|PingRsp|old|{"retcode":0}
Warn|1001|10000|skill_issue_detect(async)|PingRsp|new|{}
```

## OrderPacket Policy

Due to some special reasons, a certain anime game requires that some packets must be transmitted in order, otherwise it may cause unknown problems.

In the development process of Protoshift, the issue was initially handled using asynchronous processing and queue synchronization, but it was abandoned due to poor performance in practice. Now, for strictly ordered packets, **the next packet will not be processed at all until the previous one is completed and sent**.

Currently, Protoshift uses the 'unordered' strategy, which means that except for a small number of packets, all other packets are processed in strict order. You can change which packets are allowed to be processed in the background and transmitted unordered by modifying the `List<string> unordered_messages` in `csharp-Protoshift/GameSession/Protoshift/HandlerSession.Protoshift.cs`.

## Building Your Own Protos Remote Git Repository

The Proto repository available for general users is our [mihomo-protos](https://github.com/YYHEggEgg/mihomo-protos).

Obviously, the easiest way is to directly fork this repository and make modifications based on it. If you do so, you only need to pay attention to the format of `protostat.json`:

```json
{
    "$schema": "protostat_schema.json",
    "CurrentStat": "Valid",
    "ReleaseTime": "2023-10-23T06:12:00+00:00"
}
```

The `ReleaseTime` is used to indicate the version of the `Proto`. It is actually only used to synchronize with other distribution versions, and the Proto update itself depends only on Git pull. If the repository never sets a `RedirectUrl`, you can leave all values unchanged.

Next, let's introduce the Proto repository format for use with csharp-Protoshift:

- The `Protos` directory contains all target Protos. Try to ensure that there are no subdirectories inside, as it may cause unknown issues.
- The `cmdid.csv` contains the mapping between Proto names and CmdId. There is no header, only two columns, one for the name and the other for the number.
- If it is for internal use within you or your organization, `ThirdPartyLicenses` is not necessary. The same applies to scripts like `compileprotos`.
- At least one `protostat.json` should be kept, and the `CurrentStat` must be set to `Valid`.
- Use the following `.gitignore` file:

  ```ignore
  /Compiled
  /Proto2json_Output
  ```

- The branch name is the identifier of the Proto version. If you have a main branch like `mihomo-protos` which serves as a base but does not contain actual Protos, it is recommended to set its `CurrentStat` to `Deprecated` in its `protostat.json` file.

After setting up your own Proto Git remote repository, you may need to instruct your collaborators to use the new source or change branches. For more detailed information, please refer to [Wiki - Building - Managing Proto Remote Fetch](EN_Building#proto-remote-fetch-management).
