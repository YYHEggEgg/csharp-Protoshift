# csharp-Protoshift

<div align="center">
    <img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/YYHEggEgg/csharp-Protoshift?logo=csharp&style=for-the-badge"> 
    <img alt="GitHub" src="https://img.shields.io/github/license/YYHEggEgg/csharp-Protoshift?style=for-the-badge"> 
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/YYHEggEgg/csharp-Protoshift?style=for-the-badge"> 
    <img alt="GitHub Workflow Status" src="https://img.shields.io/github/actions/workflow/status/YYHEggEgg/csharp-Protoshift/pull-request-check.yml?branch=development&logo=github&style=for-the-badge">
</div>

[EN](../README.md) | 中文

**注意**: 我们始终欢迎项目的贡献者。但在做贡献之前，请仔细阅读我们的 [代码规范](https://github.com/YYHEggEgg/csharp-Protoshift/blob/main/CONTRIBUTING.md)。

## 目前支持的功能

- 基础 Protoshift 功能
- 中间人抓包
- Windy (lua) 脚本自动编译执行
- Protobuf / `query_cur_region` 工具命令、

## 快速安装指南

### 前置环境需求

您首先需要确认您已经安装了以下软件：

- [.NET 6.0 Runtime](https://dotnet.microsoft.com/en-us/download)。它用于生成与运行软件。
- [Git](https://git-scm.com/downloads)。它用于克隆源代码以及收取本软件的更新。
- [Protocol Buffers 编译器（protoc）](https://github.com/protocolbuffers/protobuf/releases/tag/v21.12)，并添加到您的系统的 PATH 环境变量。它用于实时编译必要文件。为保持一致性，我们建议使用版本 21.12。
  **注意请根据您的系统下载下方以 `protoc` 开头的压缩包。** [v21.12 Windows x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-win64.zip) | [v21.12 Linux x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-linux-x86_64.zip)
- 一个真正的服务器。

除此之外，我个人强烈建议您：

- 在运行构建（`./update`）时保证对 GitHub 的**稳定**访问。
- 使用 VS Code 以获得路径快捷跳转、JSON Schema 等支持。

如果您由于某些原因无法将以上软件添加到系统环境变量，也可以参照 FAQs 中的内容进行 [特殊配置]() 以临时解决问题。

### 构建并运行

确认完成了前置条件后，只需要运行以下命令即可：

```sh
git clone --branch main https://github.com/YYHEggEgg/csharp-Protoshift
cd csharp-Protoshift
./update
```

完成后，您还需要进行一些配置。打开 [csharp-Protoshift/config.json](../csharp-Protoshift/config.json)，便可以看到注释行 _（注意这个文件只有构建完毕才有）_：

```json
{
// ...
  "NetConfig": {
    "BindAddress": "0.0.0.0",
    "BindPort": 22102,
    // Set your real server ip here
    // "RemoteAddress": {
    //   "IpAddress": "127.0.0.1",
    //   "AddressPort": 20041
    // }
  },
// ...
}
```

取消注释并以您的真实服务器地址替换，再运行以下命令：

```sh
./run
```

就可以立刻启动服务器。您以后也可以随时使用 `./run` 启动 Protoshift 服务器，使用 `./update` 来获取更新。

## 高级用法

- 有关导出稳定的发布版本，您可以参见 [Wiki - Building]() 指南。
- 有关指令更具体的用法，您可以参见 [Wiki - Commands]() 指南。
- 构建时使用 [默认行为文件](../HandlerGenerator/Gencode_Configuration/default_protobuf_branches.txt) 中定义的 Proto 分支。有关使用其他 Proto 分支或更换仓库源，您可以参见 [Wiki - Building]() 指南。
