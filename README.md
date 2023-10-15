# csharp-Protoshift

<div align="center">
    <img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/YYHEggEgg/csharp-Protoshift?logo=csharp&style=for-the-badge"> 
    <img alt="GitHub" src="https://img.shields.io/github/license/YYHEggEgg/csharp-Protoshift?style=for-the-badge"> 
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/YYHEggEgg/csharp-Protoshift?style=for-the-badge"> 
    <img alt="GitHub Workflow Status" src="https://img.shields.io/github/actions/workflow/status/YYHEggEgg/csharp-Protoshift/pull-request-check.yml?branch=development&logo=github&style=for-the-badge">
</div>

EN | [中文](docs/README_CN.md)

**Note**: We always welcome contributors to the project. But before making contributions, please read our [Code of Conduct](CONTRIBUTING.md) carefully.

## Current Features

- Basic Protoshift functionality. It can enhance the compatibility of certain secondary game servers.
- Simple proxy server management commands.
- Automatic compilation and execution of Windy (lua) scripts. The image below shows the `welcome-to-csharp-Protoshift.lua` configuration that is enabled by default in `config_example.json`. You can disable it by setting `#/WindyConfig/OnlineExecWindyMode` to `Disabled`.

  ![Windy Preview](csharp-Protoshift/Images/windy_welcome-to-csharp-Protoshift.jpg)

- Protobuf / `query_cur_region` / Ec2b and other utility commands.

## Quick Installation Guide

### Prerequisites

First, you need to make sure you have installed the following software:

- [.NET 6.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). It is used to generate and run the software.
- [Git](https://git-scm.com/downloads). It is used to clone the source code and receive updates for this software.
- [Protocol Buffers Compiler (protoc)](https://github.com/protocolbuffers/protobuf/releases/tag/v21.12), and add it to your system's PATH environment variable. It is used for real-time compilation of necessary files. For consistency, we recommend using version 21.12.  
  **Please download the zip package starting with `protoc` at the bottom of the release page according to your system**. Here are some download links: [v21.12 Windows x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-win64.zip) | [v21.12 Linux x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-linux-x86_64.zip)
- A real server.

In addition, I strongly recommend that you:

- Ensure **stable** access to GitHub when running the build (`./update`).
- Use VS Code for path shortcut jumps, JSON Schema support, etc.

If for some reason you cannot add the above software to the system environment variables, you can instruct the program to call their absolute paths. For details on this special configuration, please refer to the [Wiki - Building - Prerequisites](docs/wiki/EN_Building.md#prerequisites) guide.

### Build and Run

Once the prerequisites are met, just run the following commands:

```sh
git clone --branch main https://github.com/YYHEggEgg/csharp-Protoshift
cd csharp-Protoshift
./update
```

After that, you need to do some configuration. Open [csharp-Protoshift/config.json](csharp-Protoshift/config.json), and you will see the commented lines _（note that this file only exists after the build is complete）_:

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

Uncomment and replace with your real server address to complete the minimum configuration of `config.json`. After configuring `config.json`, you should confirm whether `resources` is correctly configured. For how to correctly configure `resources`, please refer to [Wiki - Resources](docs/wiki/EN_Resources.md).

Finally, run the following command to start the server immediately:

```sh
./run
```

You can also use `./run` to start the Protoshift server at any time, and use `./update` to get updates. Of course, if you want to run in Release mode (for higher performance), you can use `./scripts/run-rel`.

## More Usage

- For exporting stable release versions, you can refer to the [Wiki - Building - Exporting a Single Release Version](docs/wiki/EN_Building.md#exporting-a-single-release-version) guide.
- For more specific command usage, you can refer to the [Wiki - Commands](docs/wiki/EN_Commands.md) guide.
- The build uses the Proto branches defined in the [default behavior file](HandlerGenerator/Gencode_Configuration/default_protobuf_branches.txt). For using other Proto branches or changing the repository source, you can refer to the [Wiki - Building - Proto Remote Fetch Management](docs/wiki/EN_Building.md#proto-remote-fetch-management) guide.
