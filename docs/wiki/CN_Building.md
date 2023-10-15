## 内容速览

- [前置环境需求](#前置环境需求)
- [进行构建](#进行构建)
- [Proto 远程抓取管理](#proto-远程抓取管理)
- [进行个性化配置](#进行个性化配置)
- [导出单个发布版本](#导出单个发布版本)
- [生成后任务](#生成后任务)

如果是第一次来，建议您完整阅读本文内容。

## 前置环境需求

您首先需要确认您已经安装了以下软件：

- [.NET 6.0 Runtime](https://dotnet.microsoft.com/zh-cn/download/dotnet/6.0)。它用于生成与运行软件。
- [Git](https://git-scm.com/downloads)。它用于克隆源代码以及收取本软件的更新。
- [Protocol Buffers 编译器（protoc）](https://github.com/protocolbuffers/protobuf/releases/tag/v21.12)，并添加到您的系统的 PATH 环境变量。它用于实时编译必要文件。为保持一致性，我们建议使用版本 21.12。  
  **注意请根据您的系统下载发行页下方以 `protoc` 开头的压缩包**。此处同样提供部分下载链接：[v21.12 Windows x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-win64.zip) | [v21.12 Linux x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-linux-x86_64.zip)
- 一个真正的服务器。

除此之外，我个人强烈建议您：

- 在运行构建（`./update`）时保证对 GitHub 的**稳定**访问。
- 使用 VS Code 以获得路径快捷跳转、JSON Schema 等支持。

如果您由于某些原因无法将以上软件添加到系统环境变量，可以打开 `HandlerGenerator/OuterInvokeConfig.cs`。您将看到以下代码：

```cs
public const string protoc_path = "protoc";
/// ...
public const string dotnet_path = "dotnet";
/// ...
public const string git_path = "git";
```

将以上常量的值替换为您的程序安装位置。注意，**这不会改变脚本中引用的程序位置**。您可能同样需要对其进行修改。

## 进行构建

通常而言，最常用的构建是直接运行更新脚本 `./update`。这会自动更新您的 Proto 版本并重新运行构建（如果存在更新）。

`./update` 将会运行项目 `HandlerGenerator`。它在运行时可能会提示用户进行操作（或单纯的只是提示您按 Enter 退出）。如果想要使程序不间断运行，可以使用 `./update -y`。

如果您是一位开发者，在您自行更改了 Proto 的情况下，您可能希望不运行拉取更新但仍然重新生成 Protoshift Handlers。这种情况下，建议您直接在文件夹 `HandlerGenerator` 中运行 `dotnet run` 来达到需求。

另外，命令行参数实际由 `HandlerGenerator` 解析。因此，上文提到的任何可以对 `./update` 使用的参数均可对 `dotnet run` 使用 - 但是需要注意 `dotnet run` 的语法：传递给 `dotnet run` 的参数与程序的参数之间需要以 `--` 分隔。

## Proto 远程抓取管理

您可以使用以下参数指定从远端获取 Proto：

```sh
./update --branch-oldprotos [branch] --branch-newprotos [branch]
```

其中的 Branch 为远端存储库中可用的分支。  

您可以在此查看 [默认的 Proto 存储库](https://github.com/YYHEggEgg/mihomo-protos)。也可以在 `HandlerGenerator/Gencode_Configuration/protobuf_source_git.txt` 中对其进行更改。

注意，使用 GitHub 以外的存储库会导致程序的某些行为发生改变。由于其未经充分测试，可能带来未知的问题。

如果不指定参数而本地又没有 Proto 的话，程序会使用默认的分支进行克隆。其在 `HandlerGenerator/Gencode_Configuration/default_protobuf_branches.txt` 中配置。

## 进行个性化配置

在生成 Protoshift Handlers 后，应修改 `config.json` 以进行有效配置。如果您使用支持 JSON Schema 的编辑器编辑 `config.json`，应可以看到字段的注释并使用自动填充特性。  
配置完 `config.json` 后，应确认 `resources` 是否正确配置。有关如何对 `resources` 进行正确配置，请参阅 [Wiki - Resources](CN_Resources.md).

另外，在您进入游戏时，应可以看到如下效果。如果您想要禁用此特性，您可以通过在 `config.json` 中将 `#/WindyConfig/OnlineExecWindyMode` 设为 `Disabled` 来将其关闭。

  ![Windy Preview](../../csharp-Protoshift/Images/windy_welcome-to-csharp-Protoshift.jpg)

## 导出单个发布版本

有些时候，您可能希望脱离代码而导出单个发布版本以供长期使用，或将其移动到其他设备。

如果想导出一个发行版本，可以运行以下命令：

```sh
./scripts/publish
```

这将会在成功还原 Proto 与生成 Handlers 后，以 Release 配置生成至 `Builds` 文件夹中，其文件夹名为 `output_[今天的日期]_[本地存储库最新的 Git Hash]`，例如 `output_20231007_505e671421`。

如果您的真实服务器在 Unix 平台上运行，**强烈建议您将 Protoshift 服务器与真实服务器在同一台机器上运行**（对于容器化的服务器可能可以使用其他类似的方法），因为此时 Protoshift 服务器与真实服务器间的本地网络通信将直接使用内存拷贝。[网络测试](https://github.com/YYHEggEgg/csharp-Protoshift/actions/workflows/network-test.yml) 的相关数据表明，这样做可以使网络速度提升 $45\%$ 以上。

### 生成后任务

如果想要运行自动化任务（例如 scp），可以自定义生成后任务脚本：

1. 找到文件夹 `HandlerGenerator/Gencode_Configuration`。其目录下有两个文件，分别是 `afterbuild_task_win.tmpl.ps1` 和 `afterbuild_task_unix.tmpl.sh`。
2. 根据你当前的平台，选择其中一个在目录下创建一个副本，并删去文件名中的 `.tmpl`。例如，如果您当前系统为 Windows，那么您应该克隆 `afterbuild_task_win.tmpl.ps1` 并将其改名为 `afterbuild_task_win.ps1`。
3. 在 `HandlerGenerator` 完成构建时，生成的 Build 所在文件夹的完整路径将被作为唯一的参数传入脚本。之后您就可以通过编写脚本完成任何想要完成的任务。
