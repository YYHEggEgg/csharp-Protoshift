The commands available on the Protoshift server are mainly proxy service control commands and some utility commands.

# Command Overview

- [Proxy Service Control Commands](#proxy-service-control-commands)
  - [`target` Command](#target-command)
  - [`kick` Command](#kick-command)
  - [`injectpkt` Command](#injectpkt-command)
  - [`queryclient` Command](#queryclient-command)
  - [`windy` Command](#windy-command)
    - [`send` Subcommand](#send-subcommand)
    - [`set-env` Subcommand](#set-env-subcommand)
    - [`set-luac-path` Subcommand](#set-luac-path-subcommand)
    - [`set-temp-path` Subcommand](#set-temp-path-subcommand)
- [Utility Commands](#utility-commands)
  - [`dcurr` Command](#dcurr-command)
  - [`gencur` Command](#gencur-command)
  - [`convert` Command](#convert-command)
  - [`ec2b` Command](#ec2b-command)
  - [`protobuf` Command](#protobuf-command)
    - [`target` Subcommand](#target-subcommand)
    - [`start` Subcommand](#start-subcommand)
- [Proto HotPatch Command](#proto-hotPatch-command)

## Proxy Service Control Commands

Firstly, for an online session, there are two attributes that need to be distinguished:

- Conv ID is the unique session ID for network communication between the client and the server, which is related to the underlying KCP network protocol. It should become invalid as the session ends (for example, exit the game, reconnect, etc.).
- UID is a meaningful identifier for an online player, which can be guaranteed to be valid for a long time.

Currently, most commands support using UID and Conv ID as parameters to identify their targets, and also support using the `target` command to specify the default target UID used. Except for the `queryclient` commands, all proxy service control commands support the following parameters: _(*)_

```sh
[command] <player_uid> | -c, --conv <conv_id>
```

Here, `player_uid` is the UID of the target player, and `conv_id` is the network session ID.

If both are provided, `conv_id` will be used preferentially and a warning will be issued. If neither is provided, the default player UID set by the `target` command will take effect.

(*: Due to a value conflict, `windy` command should use option `-u` to specify a UID. For more information, see [`windy` command](#windy-command). )

### `target` Command

The syntax of the `target` command is as follows:

```sh
target <player_uid>
```

Except that `player_uid` cannot be 0, there are no other restrictions, but a warning will be issued when the UID is not online.

### `kick` Command

The `kick` command can immediately end an online session.

```sh
kick <player_uid> | -c, --conv <conv_id>
     --client-reason [ENetReason_id]
     --server-reason [ENetReason_id]
```

The `kick` command will send requests to disconnect to the server and client respectively, and `ENetReason_id` is the parameter used. For its available values and specific meanings, you can refer to `OldProtoHandlers/Google.Protobuf/Protos/ENetReason.proto` in your local directory or [its online version](https://github.com/YYHEggEgg/mihomo-protos/blob/3.4_live/Protos/ENetReason.proto).

Here is an example of using this command, you can execute it and see the effect:

```sh
target [your_online_UID]
kick
```

### `injectpkt` Command

The `injectpkt` command allows you to send specific packet content to the specified session.

```sh
injectpkt <player_uid> | -c <conv_id>
          [--client] | [--server]
          -p, --proto <protoname>
          [--head <packet_head_hex>]
          [--body <protobuf_body_hex>]
```

`--client` and `--server` indicate sending to the client or server. `-p` indicates the Proto used by the package, which must have a valid CmdId, which can be found in your `resources/protobuf` file.

The content carried by `--head` and `--body` needs to be the big-endian hexadecimal expression of Protobuf. You can also not provide these parameters to send an empty Head or Body.

### `queryclient` Command

If you want to query online players, you can use the `queryclient` command:

```sh
queryclient -l, --limit <query_limit=50>
            --range-from <uid_minimum>
            --range-to <uid_maximum>
```

All three parameters are optional. `--range-from` and `--range-to` are used to limit the UID range of the users found, while `--limit` is used to limit the number of users output. It is worth noting that when the online session has not received `GetPlayerTokenRsp`, their UID is all 0.

`queryclient` will find online player information with the given UID range (if no range parameters are specified, no restrictions will be made). The command will output the Conv ID, UID and connection IP information of the players found on the console. Here is an example output:

```log
<Info:QueryClientCmd> Found uid: 10000, conv: 1003, IP address: 127.0.0.1:54263
```

After obtaining the Conv ID of the target session, you can operate on it through other proxy control commands.

Here is an example of using this command, you can execute it and see the result:

```sh
queryclient -l 1
```

### `windy` Command

The `windy` command is used to manage the remote execution of lua scripts.

Unlike most existing Windy implementations, this `windy` command allows you to directly specify lua scripts and send them to the client after automatic compilation.

#### `send` Subcommand

`send` is the default subcommand. It can immediately send `WindSeedClientNotify` to the specified client (or all online clients).

```sh
windy [send] -u <player_uid> | -c, --conv <conv_id> | --everyone
             <lua_file_path> | --compiled <compiled_luac_path>
```

Among these parameters:

- `-u <player_uid>`, `-c <conv_id>`, `--everyone` are options to specify the execution target.  
  When specifying `--everyone`, if the online client >= 2, a warning will be issued and you will be asked to confirm whether to execute the operation. If the online client >= 5, you will be asked to enter the name of the lua script to continue.
- You can directly fill in the file path to execute the specified lua script, or you can use the `--compiled` parameter to specify to run the compiled file directly. The program will look for the specified file in the lua environment path (if the extension is `.lua` it can be omitted), but still accepts absolute paths.

Here is an example of using this command, you can execute it and see the effect:

```sh
target [your_online_UID]
windy welcome-to-csharp-Protoshift
```

#### `set-env` Subcommand

`set-env` can change the lua environment path. The `windy` command uses this path as the base folder for relative paths to find the files specified in the `send` subcommand.

```sh
windy set-env <dir-full-path>
```

You can also modify `#/WindyConfig/WindyEnvironmentPath` in `config.json` to change it. Conversely, the lua environment path modified by `windy set-env` will be synchronized to `config.json` when the server is closed. This behavior also applies to the `set-luac-path` and `set-temp-path` subcommands.

#### `set-luac-path` Subcommand

`set-luac-path` can change the path of the `luac` compiler used by the program under a specific operating system.

```sh
windy set-luac-path -t, --targetOS <OSType>
                    <luac_path>
```

The `--targetOS` parameter is used to specify the `luac` compiler path applicable to this configuration. Note that if you want to provide a relative path for this path, **this path should be relative to the working directory of the program at runtime (should be on the same level as the `resources` folder) rather than the lua environment path.**

If the current OS type matches the `--targetOS` parameter, it will query and report the version number of the provided `luac` compiler. If the command fails to run, it will refuse to change.

#### `set-temp-path` Subcommand

`set-temp-path` can change the temporary file storage path of luac compilation.

```sh
windy set-temp-path <temp-path>
```

Note that if you want to provide a relative path for this path, **this path should be relative to the working directory of the program at runtime (should be on the same level as the `resources` folder) rather than the lua environment path.**

## Utility Commands

To facilitate you to complete some simple daily tasks, this program provides some utility commands. These commands are prefixed with `util` when called.

You can also use the `--utils-only` option to start the program to only start utility commands without starting the Protoshift network server.

### `dcurr` Command

The `dcurr` command can help you quickly get the content of the standardized `query_cur_region` HTTP response.

```sh
util dcurr <key_id> <curr_json>
```

`key_id` is the number of the RSA key pair to be used (can be found in `resources/rsakeys`).

`curr_json` is the body content of the received HTTP response, and JSON should carry `content` and `sign`. Please note that since `curr_json` must be single-line, if you paste multi-line text, you need to follow the following principles:

- If you are using the console on this machine, you can directly press Ctrl + V to paste;
- If you are using Windows Terminal, press Ctrl + Alt + V to paste;
- For remote terminals such as VSCode Remote or SSH, please convert the text to a single line before pasting.

The `dcurr` command will deserialize the content into JSON that conforms to `QueryCurrRegionHttpRsp`, and use the local RSA private key (ServerPri or ServerPub) to verify the signature. Therefore, if you encounter a prompt that the signature verification failed, the RSA private key on your local machine does not match the private key used by the server that generated the `query_cur_region` content, which means that your local Protoshift cannot act as a proxy between the client and the target server.

### `gencur` Command

The `gencur` command is similar to the `dcurr` command, it uses the provided `QueryCurrRegionHttpRsp` JSON form to generate valid `query_cur_region` content.

```sh
util gencur <key_id> <protobuf_content>
```

Note that the format of the parameter `<protobuf_content>` may be different from other ways to get it: it uses camel case naming except for the first letter, rather than the underscore form used in the original proto. For example, `region_info` is named `regionInfo` in it.

For notes on pasting content as its parameters, please refer to [`dcurr` Command](#dcurr-command).

### `convert` Command

The `convert` command can convert the input content between base64 and HEX (hexadecimal string).

```sh
convert <base64_data/hex_data>
```

The input type will be automatically detected. If there is a problem with automatic detection, you can add `b-`, `h-` or `j-` before the input data to forcibly specify that the input type is base64, HEX or JSON.

For notes on pasting content as its parameters, please refer to [`dcurr` Command](#dcurr-command).

### `ec2b` Command

The `ec2b` command can get the `server_secret_key` (also known as `dispatchKey`) through the `client_secret_key` (also known as `dispatchSeed`).

```sh
util ec2b get_key <content_bindata(base64/hex)>
```

Generally speaking, you can find the `client_secret_key` (that is, `dispatchSeed`) in `QueryCurrRegionHttpRsp`, but the server actually uses `dispatchKey` as the initial XOR key.

For explanations of supporting multiple input types at the same time, please refer to [`convert` Command](#convert-command).  
For notes on pasting content as its parameters, please refer to [`dcurr` Command](#dcurr-command).

### `protobuf` Command

The `protobuf` command can perform some simple operations using the proto that comes with the Protoshift server generation.

#### `target` Subcommand

The Protoshift server must come with two sets of Protobuf, and their naming methods are often similar, so the `protobuf` command requires specifying which one to use specifically.

```sh
util protobuf target <old|new>
```

`old` refers to the Protobuf used by the server, and `new` refers to the Protobuf used by the client. `old` and `new` are actually relative to the release time. This naming method is valid for any other scenario of this program.

#### `start` Subcommand

The `start` subcommand starts a `protobuf` wizard.

```sh
util protobuf [--old/--new] <proto_name>
```

Even though you never used `target` Subcommand, `--old` or `--new` option can also be used to specify the Protobuf version. `proto_name` is the name of the target Proto.

After starting the wizard, if the corresponding proto is found successfully, you will be prompted to enter content:

```log
<Info:ProtobufCmd> Well done! The proto exists.
<Info:ProtobufCmd> Please type base64 encoded, HEX or JSON protobuf bin data (auto detect):
<Info:ProtobufCmd> You can also paste json data to get its serialized data.
```

For explanations of supporting multiple input types at the same time, please refer to [`convert` Command](#convert-command).  
For notes on pasting content as its parameters, please refer to [`dcurr` Command](#dcurr-command).

## Proto HotPatch Command

Use the `kskillissue` command to reload `protoshift_hotpatch_config.json`.

For specific usage of Proto HotPatch, please refer to its [Readme](https://github.com/YYHEggEgg/csharp-Protoshift/blob/development/csharp-Protoshift/ProtoHotPatch/README.md).
