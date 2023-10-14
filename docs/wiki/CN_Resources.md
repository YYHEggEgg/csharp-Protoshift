通常而言，资源文件被置于 `csharp-Protoshift/resources` 目录下。在导出单个发布版本时，该文件夹也会被复制到程序目录下。

下面的内容以个性化的必要性（从大到小）排序。

## `xor` 文件夹

不同服务器之间很可能使用不同的 dispatchKey，因此建议您完整执行以下步骤以确认程序能以正确的方式运行。

1. 寻找您的服务器使用的 `dispatchSeed.bin` 与 `dispatchKey.bin` 的现有文件。这显然是最简便的方法，可以省去许多的麻烦。如果找到了，请以这些文件替换 `resources/xor` 以下的现有文件。
2. 如果您无法找到相应的文件，请您先运行构建，然后运行 `./run --utils-only` 来以仅工具命令模式启动。它们在下文中将可能被使用。
3. 您可以前往您的数据库寻找内容，例如寻找 `server_secret_key` 字段的内容（如果有）。如果导出的内容为 HEX 字符串，您可能需要使用一个十六进制编辑器来写入内容至文件；如果导出的内容为 base64 字符串，您可以参考 [util `convert` 命令](CN_Commands.md#convert-命令) 来将其转换为 HEX 字符串。
4. 如果您上一步也无法做到，请向您的服务器发送一个有效的 `query_cur_region` 请求，并复制响应体，然后运行 [util `dcurr` 命令](CN_Commands.md#dcurr-命令)。  
   获取到解密后 JSON 后，请您在其中寻找名为 `clientSecretKeyEncrypted` 的字段，它是 base64 格式的 `client_secret_key`。使用 [util `convert` 命令](CN_Commands.md#convert-命令) 来将其转换为 HEX 字符串，再使用一个十六进制编辑器来写入转换后内容至 `resources/xor/dispatchSeed.bin`。
5. 结束上述步骤后，即使您只有 `dispatchSeed.bin`，也应该可以启动服务器，但可能会收到警告。如果您想要解除警告，可以使用 [util `ec2b` 命令](CN_Commands.md#ec2b-命令) 生成 `server_secret_key` 并使用一个十六进制编辑器写入 `resources/xor/dispatchKey.bin`。

## `windy-scripts` 文件夹

这里是默认的 lua 环境路径，您可以在此处存放运行 windy 的 lua 脚本。有关更多关于 windy 的信息，请参阅 [`windy` 命令](CN_Commands.md#windy-命令)。

## `rsakeys` 文件夹

其中包含了 `ClientPri` 与 `ServerPri` 文件夹。

通常而言，您不需要更改 `ClientPri` 中的文件。而如果您生成过自己的 `server_private_key`，应该也知道如何配置 `ServerPri` 文件夹中的内容，故此处省略这些内容。大部分情况下，您使用的 `server_private_key` 都是 GC Key，因此不需进行任何操作。

您可以配置专用于 [util `dcurr` 命令](CN_Commands.md#dcurr-命令) 的 `ServerPub` 密钥，用于在解密 `query_cur_region` 时对内容进行签名验证。**您仍需要 `ServerPri` 密钥运行服务器**，这也就意味着，您不能将该 Protoshift 实现作为任意服务器的代理抓包软件。

## `luac_bins` 文件夹

这里存放默认分发的供 Windy 使用的 luac 编译器。

建议不要更改。如果想要使用自己的 luac 编译器，建议您在 `config.json` 中指定本地计算机上其他的路径。

## `config-schemas` 文件夹

其中包含程序使用 `config.json` 的 JSON Schema。程序需要使用其中的文件来确保提供的 `config.json` 符合配置。

通常而言，由于兼容性原因，一个版本的 config JSON Schema 在正式发布后便不应再更改。

## `protobuf` 文件夹

此处以前需要手动填入 `oldcmdid.csv` 与 `newcmdid.csv`，但是现在它由 `HandlerGenerator` 的构建流程自动管理。

不应手动更改。
