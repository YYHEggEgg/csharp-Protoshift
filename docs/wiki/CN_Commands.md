Protoshift 服务器可用的命令主要是代理服务控制命令和一些工具类命令。

# 命令速览

- [代理服务控制命令](#代理服务控制命令)
  - [`target` 命令](#target-命令)
  - [`kick` 命令](#kick-命令)
  - [`injectpkt` 命令](#injectpkt-命令)
  - [`queryclient` 命令](#queryclient-命令)
  - [`windy` 命令](#windy-命令)
    - [`send` 子命令](#send-子命令)
    - [`set-env` 子命令](#set-env-子命令)
    - [`set-luac-path` 子命令](#set-luac-path-子命令)
    - [`set-temp-path` 子命令](#set-temp-path-子命令)
- [工具类命令](#工具类命令)
  - [`dcurr` 命令](#dcurr-命令)
  - [`gencur` 命令](#gencur-命令)
  - [`convert` 命令](#convert-命令)
  - [`ec2b` 命令](#ec2b-命令)
  - [`protobuf` 命令](#protobuf-命令)
    - [`target` 子命令](#target-子命令)
    - [`start` 子命令](#start-子命令)
- [Proto HotPatch 命令](#proto-hotPatch-命令)

## 代理服务控制命令

首先，对于一个在线会话而言，有以下两个需要区分的属性：

- Conv ID 是客户端与服务端间进行网络通信的唯一会话 ID，其与下层 KCP 网络协议有关。其应随着会话结束而失效（例如退出游戏、断线重连等）。
- UID 则是一个在线玩家的有意义标识，可以长期保证有效。

目前，大部分命令已经同时支持使用 UID 与 Conv ID 作为参数来标识其目标，同时也支持使用 `target` 命令来指定默认情况下使用的目标 UID. 除 `queryclient` 和 `setverbose` 命令以外，所有代理服务控制命令均支持以下参数：

```sh
[command] <player_uid> | -c, --conv <conv_id>
```

其中，`player_uid` 为目标玩家的 UID，而 `conv_id` 为网络会话 ID。

如果都提供，则会优先使用 `conv_id` 并发出警告。如果都不提供，则之前使用 `target` 命令设定的默认玩家 UID 会生效。

### `target` 命令

`target` 命令的语法如下：

```sh
target <player_uid>
```

除了 `player_uid` 不能为 0 之外，没有其他的限制条件，但会在 UID 未在线时发出警告。

### `kick` 命令

`kick` 命令可以立刻结束一个在线会话。

```sh
kick <player_uid> | -c, --conv <conv_id>
     --client-reason [ENetReason_id]
     --server-reason [ENetReason_id]
```

`kick` 命令会向服务器与客户端分别发送断开连接的请求，`ENetReason_id` 则为使用的参数。有关其可用数值与具体意义，可以参见您本地目录下的 `OldProtoHandlers/Google.Protobuf/Protos/ENetReason.proto` 或 [其在线版本](https://github.com/YYHEggEgg/mihomo-protos/blob/3.4_live/Protos/ENetReason.proto)。

### `injectpkt` 命令

`injectpkt` 命令支持您向指定的会话发送特定的包内容。

```sh
injectpkt <player_uid> | -c <conv_id>
          [--client] | [--server]
          -p, --proto <protoname>
          [--head <packet_head_hex>]
          [--body <protobuf_body_hex>]
```

`--client` 和 `--server` 分别指示发送到客户端或服务端。`-p` 指示包使用的 Proto，其必须具有一个有效的 CmdId，可参见您的 `resources/protobuf` 中的文件。

`--head` 与 `--body` 所带的内容均需要为 Protobuf 的大端十六进制表达形式。也可以不提供这些参数以发送空的 Head 或 Body。

### `queryclient` 命令

如果想要查询在线的玩家，可以使用 `queryclient` 命令：

```sh
queryclient -l, --limit <query_limit=50>
            --range-from <uid_minimum>
            --range-to <uid_maximum>
```

三个参数均为可选参数。`--range-from` 与 `--range-to` 用于

`queryclient` 将以给定的 UID 范围查找在线的玩家信息（如果未指定范围参数则不作限制）。命令将会在控制台输出查找到玩家的 Conv ID，UID 以及连接 IP 等信息。以下是一个示例输出：

```log
<Info:QueryClientCmd> Found uid: 10000, conv: 1003, IP address: 127.0.0.1:54263
```

获取到目标会话的 Conv ID 后，便可以通过其他代理控制命令对其进行操作。

### `windy` 命令

`windy` 命令用于管理远程执行 lua 脚本。

与大部分现有的 Windy 实现不同，本 `windy` 命令支持您直接指定 lua 脚本，并在自动编译后发送至客户端。

#### `send` 子命令

`send` 为默认的子命令。它可以向指定客户端（或所有在线客户端）立刻发送 `WindSeedClientNotify`

```sh
windy [send] -u <player_uid> | -c, --conv <conv_id> | --everyone
             <lua_file_path> | --compiled <compiled_luac_path>
```

这些参数中：

- `-u <player_uid>`、`-c <conv_id>`、`--everyone` 都是指定执行目标的选项。  
  在指定 `--everyone` 时，如果在线客户端 >= 2 个，则会发出警告并指示您确认是否要执行操作。如果在线客户端 >= 5 个，则会指示您输入执行的 lua 脚本名称以继续。
- 可以直接填写文件路径来执行指定的 lua 脚本，也可以使用 `--compiled` 参数来指定直接运行编译后的文件。程序将在 lua 环境路径查找指定的文件（如果扩展名为 `.lua` 则可以省略），但仍接受绝对路径。

#### `set-env` 子命令

`set-env` 可改变 lua 环境路径。`windy` 命令使用该路径作为相对路径的基文件夹，查找 `send` 子命令中指定的文件。

```sh
windy set-env <dir-full-path>
```

您也可以在 `config.json` 中修改 `#/WindyConfig/WindyEnvironmentPath` 来改变它。反过来讲，使用 `windy set-env` 修改的 lua 环境路径将会在服务器关闭时被同步至 `config.json` 中。此行为同样适用于 `set-luac-path` 与 `set-temp-path` 子命令。

#### `set-luac-path` 子命令

`set-luac-path` 可改变在特定操作系统下程序使用的 `luac` 编译器的路径。

```sh
windy set-luac-path -t, --targetOS <OSType>
                    <luac_path>
```

`--targetOS` 参数用于指定此配置适用的 `luac` 编译器路径。注意，如果要为此路径提供相对路径，**此路径应相对于程序运行时的工作目录（应与 `resources` 文件夹平级）而非 lua 环境路径。**

如果当前 OS 类型与 `--targetOS` 参数符合，将会查询并报告提供的 `luac` 编译器的版本号。如果运行失败命令将会拒绝更改。

#### `set-temp-path` 子命令

`set-temp-path` 可改变 luac 编译的临时文件存储路径。

```sh
windy set-temp-path <temp-path>
```

注意，如果要为此路径提供相对路径，**此路径应相对于程序运行时的工作目录（应与 `resources` 文件夹平级）而非 lua 环境路径。**

## 工具类命令

为方便您完成一些简便的日常任务，本程序提供了一些工具类命令。这些命令调用时以 `util` 开头。

您也可以使用 `--utils-only` 选项启动程序以仅启动工具类命令而不启动 Protoshift 网络服务器。

### `dcurr` 命令

`dcurr` 命令可以帮助您快速获取标准化 `query_cur_region` HTTP 响应的内容。

```sh
util dcurr <key_id> <curr_json>
```

`key_id` 是要使用的 RSA 密钥对编号（可在 `resources/rsakeys` 中找到）。

`curr_json` 是接收到 HTTP 响应的正文内容，JSON 中应带有 `content` 和 `sign`。特别注意由于 `curr_json` 必须是单行，如果复制了多行文本粘贴时需遵循以下原则：

- 如果使用本机上的控制台，可直接按 Ctrl + V 粘贴；
- 如果使用 Windows Terminal，按 Ctrl + Alt + V 粘贴；
- 使用 VSCode Remote 或 SSH 等远程终端，请将文本转换为单行后粘贴。

`dcurr` 命令将会反序列化内容为符合 `QueryCurrRegionHttpRsp` 的 JSON，并使用本地的 RSA 私钥（ServerPri 或 ServerPub）验证签名。因此，如果您遇到提示签名验证失败，则您本地的 RSA 私钥与生成 `query_cur_region` 内容的服务器使用的私钥并不匹配，也就是说您本地的 Protoshift 无法充当客户端与目标服务器之间的代理。

### `gencur` 命令

`gencur` 命令与 `dcurr` 命令类似，其反向使用提供的 `QueryCurrRegionHttpRsp` JSON 形式来生成有效的 `query_cur_region` 内容。

```sh
util gencur <key_id> <protobuf_content>
```

注意，参数 `<protobuf_content>` 的格式可能与其他方式获取到的不同：其除了首字母以外使用驼峰形式命名，而非在原 proto 中使用的下划线形式。例如 `region_info` 在其中命名为 `regionInfo`。

有关粘贴内容作为其参数时的注意事项，请参阅 [`dcurr` 命令](#dcurr-命令)。

### `convert` 命令

`convert` 命令可以将输入的内容在 base64 与 HEX（十六进制字符串）中互相转换。

```sh
convert <base64_data/hex_data>
```

输入类型将会自动检测。如果自动检测出现问题，您可以在输入的数据之前带上 `b-`、`h-` 或 `j-` 来强制指定输入的类型是 base64、HEX 还是 JSON。

有关粘贴内容作为其参数时的注意事项，请参阅 [`dcurr` 命令](#dcurr-命令)。

### `ec2b` 命令

`ec2b` 命令可以通过 `client_secret_key`（通常也被称为 `dispatchSeed`）来获取 `server_secret_key`（通常也被称为 `dispatchKey`）。

```sh
util ec2b get_key <content_bindata(base64/hex)>
```

通常而言，您可以在 `QueryCurrRegionHttpRsp` 中找到 `client_secret_key`（也就是 `dispatchSeed`），但服务器实际上使用 `dispatchKey` 来作为最初的异或密钥。

有关同时支持多种输入类型的说明，请参阅 [`convert` 命令](#convert-命令)。  
有关粘贴内容作为其参数时的注意事项，请参阅 [`dcurr` 命令](#dcurr-命令)。

### `protobuf` 命令

`protobuf` 命令可以使用 Protoshift 服务器生成时附带的 proto 进行一些简单的操作。

#### `target` 子命令

Protoshift 服务器一定附带两套 Protobuf，并且它们的命名方式往往雷同，因此 `protobuf` 命令要求指定具体要使用哪一套。

```sh
util protobuf target <old|new>
```

`old` 指代服务端使用的 Protobuf，而 `new` 指代客户端使用的 Protobuf。`old` 与 `new` 实际上是相对于发布时间上而言的。此命名方式对于本程序的任何其他场景均有效。

#### `start` 子命令

`start` 子命令启动一次 `protobuf` 向导。

```sh
util protobuf [--old/--new] <proto_name>
```

即使未使用过 `target` 子命令，使用 `--old` 或 `--new` 选项也可以指定使用的 Protobuf 版本。`proto_name` 则为目标 Proto 的名称。

在启动向导后，如果成功找到了对应的 proto，将会提示您输入内容：

```log
<Info:ProtobufCmd> Well done! The proto exists.
<Info:ProtobufCmd> Please type base64 encoded, HEX or JSON protobuf bin data (auto detect):
<Info:ProtobufCmd> You can also paste json data to get its serialized data.
```

有关同时支持多种输入类型的说明，请参阅 [`convert` 命令](#convert-命令)。  
有关粘贴内容作为其参数时的注意事项，请参阅 [`dcurr` 命令](#dcurr-命令)。

## Proto HotPatch 命令

使用 `kskillissue` 命令将会重新加载 `protoshift_hotpatch_config.json`。

有关 Proto HotPatch 的具体用法，请参阅其 [Readme](https://github.com/YYHEggEgg/csharp-Protoshift/blob/development/csharp-Protoshift/ProtoHotPatch/README.md).
