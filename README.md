# csharp-Protoshift

<div align="center">
    <img alt="GitHub release (latest by date)" src="https://img.shields.io/github/v/release/YYHEggEgg/csharp-Protoshift?logo=csharp&style=for-the-badge"> 
    <img alt="GitHub" src="https://img.shields.io/github/license/YYHEggEgg/csharp-Protoshift?style=for-the-badge"> 
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/YYHEggEgg/csharp-Protoshift?style=for-the-badge"> 
    <img alt="GitHub Workflow Status" src="https://img.shields.io/github/actions/workflow/status/YYHEggEgg/csharp-Protoshift/pull-request-check.yml?branch=development&logo=github&style=for-the-badge">
</div>

<div align="center">
  <a href="https://discord.gg/NcAjuCSFvZ">
    <img alt="Discord - miHomo Software" src="https://img.shields.io/discord/1144970607616860171?label=Discord&logo=discord&style=for-the-badge">
  </a>
</div>

EN | [中文](docs/README_CN.md)

csharp-Protoshift is an advanced, manageable compatibility layer for a certain anime game.

**Note**: We always welcome contributors to the project. But before making contributions, please read our [Contributing note](CONTRIBUTING.md) carefully.

## Current Features

- Basic Protoshift functionality. It can enhance the compatibility of certain secondary game servers.
- Simple proxy server management commands.
- Automatic compilation and execution of Windy (lua) scripts. The image below shows the `welcome-to-csharp-Protoshift.lua` configuration that is enabled by default in `config_example.json`. You can disable it by setting `#/WindyConfig/OnlineExecWindys/[0]/OnlineExecMode` to `Disabled`.

  ![Windy Preview](csharp-Protoshift/Images/windy_welcome-to-csharp-Protoshift.jpg)

- Protobuf / `query_cur_region` / Ec2b and other utility commands.

## Update 

### v1.1.0

- Fixed an issue with Proto restoration pointing to the main repository (`csharp-Protoshift`) branch when the Protobuf storage folder exists but is empty.
- Fixed an issue with Proto restoration causing exceptions that affect the main repository (`csharp-Protoshift`) Git configuration when the Protobuf storage folder exists but is empty.
- Added support for completing the Proto restoration process without installing protoc.
- When running the `util protobuf` and `util dcurr` commands, if unknown fields are detected that are not defined in your Proto during the deserialization process from binary, a warning will be issued to you. You can use Protobuf decode-raw tools such as [Protobuf decoder](https://protobuf-decoder.netlify.app) to inspect the actual content carried in the data.
- The generation version of xLua has been updated for the Unix x64 version, which is now compiled on Ubuntu 20.04 to reduce the version requirement for libc.  
  The minimum Ubuntu version currently supported by GitHub Actions is `20.04`. If you are using a lower version and encounter similar format errors as below, consider forking [YYHEggEgg/xLua](https://github.com/YYHEggEgg/xLua) and run `build/luac/make_unix.sh` yourself.
  > ```
  > ./resources/luac_bins/luac_unix64: /lib/x86_64-linux-gnu/libc.so.6: version `GLIBC_2.34' not found (required by ./resources/luac_bins/luac_unix64)
  > ```

### v1.0.2

- Support initiated JIT compiling for Protoshift Handlers. For information, please view [PR #36](https://github.com/YYHEggEgg/csharp-Protoshift/pull/36).
- Fixed the issue whereby `HandlerGenerator` being unable to fetch and restore Protos due to the Git `safe.directory` configuration in certain environments.
- Fixed the issue whereby `HandlerGenerator` being unable to fetch and restore Protos when there are spaces in the project directory.
- Fixed the issue whereby `csharp-Protoshift` being unable to invoke `luac` to compile Windy lua scripts when there are spaces in the project directory.
- Fixed the issue whereby `HandlerGenerator` displaying abnormal exit prompt text when the external application invocation fails.
- Fixed the issue whereby `HandlerGenerator` being unable to correctly invoke Powershell in Windows to execute post-generation scripts when there are spaces in the project directory.
- Fixed the issue where `csharp-Protoshift-Replay` could not start due to the inability to find the resource folder.
- Fixed the problem where the command line option `--orderby-packet-speed` of `ProtoshiftBenchmark` did not actually take effect.
- Added support for proactive JIT compilation to `csharp-Protoshift-Replay`.
- Fixed the issue where `ProtoshiftBenchmark` and `csharp-Protoshift-Replay` prompted error due to syntax errors during compilation.
- Added `-f, --source-file` and `--fully-replay-packet-time` command line options to `csharp-Protoshift-Replay`.
- Fixed the running issues of the "run-benchmark" series scripts.
- Added more built-in scripts. For more information, please refer to [Wiki - Development - Built-in Scripts](https://github.com/YYHEggEgg/csharp-Protoshift/wiki/EN_Development#built-in-scripts).

## Quick Installation Guide

### Prerequisites

First, you need to make sure you have installed the following software:

- [.NET 6.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). It is used to generate and run the software.
- [Git](https://git-scm.com/downloads). It is used to clone the source code and receive updates for this software.
- A real server.

In addition, I strongly recommend that you:

- Ensure **stable** access to GitHub when running the build (`./update`).
- Use VS Code for path shortcut jumps, JSON Schema support, etc.

If for some reason you cannot add the above software to the system environment variables, you can instruct the program to call their absolute paths. For details on this special configuration, please refer to the [Wiki - Building - Prerequisite Environment Requirements](https://github.com/YYHEggEgg/csharp-Protoshift/wiki/EN_Building#prerequisite-environment-requirements) guide.

### Build and Run

Once the prerequisites are met, just run the following commands:

```sh
git clone --branch main https://github.com/YYHEggEgg/csharp-Protoshift
cd csharp-Protoshift
git submodule update --init --recursive
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

Uncomment and replace with your real server address to complete the minimum configuration of `config.json`. After configuring `config.json`, you should confirm whether `resources` is correctly configured. For how to correctly configure `resources`, please refer to [Wiki - Resources](https://github.com/YYHEggEgg/csharp-Protoshift/wiki/EN_Resources).

Finally, run the following command to start the server immediately:

```sh
./run
```

You can also use `./run` to start the Protoshift server at any time, and use `./update` to get updates. Of course, if you want to run in Release mode (for higher performance), you can use `./scripts/run-rel`.

Additionally, Protoshift does not take effect automatically on the client side; it acts as a reverse proxy, so you need to have them connect to the port opened by Protoshift server. If you are unsure how to do this, please contact your SDK server developer.

## More Usage

- For exporting stable release versions, you can refer to the [Wiki - Building - Exporting a Single Release Version](https://github.com/YYHEggEgg/csharp-Protoshift/wiki/EN_Building#exporting-a-single-release-version) guide.
- For more specific command usage, you can refer to the [Wiki - Commands](https://github.com/YYHEggEgg/csharp-Protoshift/wiki/EN_Commands) guide.
- The build uses the Proto branches defined in the [default behavior file](HandlerGenerator/Gencode_Configuration/default_protobuf_branches.txt). For using other Proto branches or changing the repository source, you can refer to the [Wiki - Building - Proto Remote Fetch Management](https://github.com/YYHEggEgg/csharp-Protoshift/wiki/EN_Building#proto-remote-fetch-management) guide.
