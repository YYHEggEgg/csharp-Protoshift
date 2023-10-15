## Content Overview

- [Prerequisite Environment Requirements](#prerequisite-environment-requirements)
- [Performing the Build](#performing-the-build)
- [Proto Remote Fetch Management](#proto-remote-fetch-management)
- [Performing Personalized Configuration](#performing-personalized-configuration)
- [Exporting a Single Release Version](#exporting-a-single-release-version)
- [Post-Build Tasks](#post-build-tasks)

If this is your first time here, we recommend that you read the entire content of this document.

## Prerequisite Environment Requirements

First, you need to make sure you have installed the following software:

- [.NET 6.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0). It is used to build and run the software.
- [Git](https://git-scm.com/downloads). It is used to clone the source code and fetch updates for this software.
- [Protocol Buffers Compiler (protoc)](https://github.com/protocolbuffers/protobuf/releases/tag/v21.12), and add it to your system's PATH environment variable. It is used to compile necessary files in real time. For consistency, we recommend using version 21.12.  
  **Please note to download the compressed package starting with `protoc` according to your system from the release page**. Here are some download links: [v21.12 Windows x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-win64.zip) | [v21.12 Linux x64](https://github.com/protocolbuffers/protobuf/releases/download/v21.12/protoc-21.12-linux-x86_64.zip)
- A real server.

In addition, I personally strongly recommend that you:

- Ensure **stable** access to GitHub when running the build (`./update`).
- Use VS Code for path shortcut jumps, JSON Schema support, etc.

If for some reason you are unable to add the above software to the system environment variables, you can open `HandlerGenerator/OuterInvokeConfig.cs`. You will see the following code:

```cs
public const string protoc_path = "protoc";
/// ...
public const string dotnet_path = "dotnet";
/// ...
public const string git_path = "git";
```

Replace the values of the above constants with the installation locations of your programs. Note that **this will not change the program locations referenced in the script**. You may also need to modify them accordingly.

## Performing the Build

Generally speaking, the most common build is to directly run the update script `./update`. This will automatically update your Proto version and rerun the build (if there are updates).

`./update` will run the `HandlerGenerator` project. It may prompt the user for action during runtime (or simply prompt you to press Enter to exit). If you want the program to run continuously, you can use `./update -y`.

If you are a developer and have changed Proto yourself, you may want to regenerate Protoshift Handlers without pulling updates. In this case, it is recommended that you run `dotnet run` directly in the `HandlerGenerator` folder to meet your needs.

Also, command line parameters are actually parsed by `HandlerGenerator`. Therefore, any parameters mentioned above that can be used with `./update` can also be used with `dotnet run` - but note the syntax of `dotnet run`: parameters passed to `dotnet run` need to be separated from program parameters with `--`.

## Proto Remote Fetch Management

You can use the following parameters to fetch Proto from remote:

```sh
./update --branch-oldprotos [branch] --branch-newprotos [branch]
```

The Branch should be available in the remote repository.  

You can view the [default Proto repository](https://github.com/YYHEggEgg/mihomo-protos) here. You can also change it in `HandlerGenerator/Gencode_Configuration/protobuf_source_git.txt`.

Note that using a repository other than GitHub may change some behaviors of the program. Since it has not been fully tested, it may bring unknown problems.

If no parameters are specified and there is no local Proto, the program will clone using the default branch. It is configured in `HandlerGenerator/Gencode_Configuration/default_protobuf_branches.txt`.

## Performing Personalized Configuration

After generating Protoshift Handlers, you should modify `config.json` for effective configuration. If you edit `config.json` with an editor that supports JSON Schema, you should be able to see field comments and use the auto-fill feature.  
After configuring `config.json`, you should check whether `resources` is correctly configured. For how to correctly configure `resources`, please refer to [Wiki - Resources](EN_Resources.md).

Also, when you enter the game, you should see the following effect. If you want to disable this feature, you can turn it off by setting `#/WindyConfig/OnlineExecWindyMode` to `Disabled` in `config.json`.

  ![Windy Preview](../../csharp-Protoshift/Images/windy_welcome-to-csharp-Protoshift.jpg)

## Exporting a Single Release Version

Sometimes, you may want to export a single release version for long-term use, or move it to other devices, independent of the code.

If you want to export a release version, you can run the following command:

```sh
./scripts/publish
```

This will generate to the `Builds` folder in Release configuration after successfully restoring Proto and generating Handlers, with the folder name being `output_[today's date]_[latest Git Hash of the local repository]`, such as `output_20231007_505e671421`.

If your real server runs on a Unix platform, **it is strongly recommended that you run the Protoshift server and the real server on the same machine** (for containerized servers, other similar methods may be used), because at this time, local network communication between the Protoshift server and the real server will directly use memory copy. The relevant data from [network testing](https://github.com/YYHEggEgg/csharp-Protoshift/actions/workflows/network-test.yml) indicates that this can increase network speed by more than $45\%$.

### Post-Build Tasks

If you want to run automated tasks (such as scp), you can customize the post-build task script:

1. Find the `HandlerGenerator/Gencode_Configuration` folder. There are two files in the directory, `afterbuild_task_win.tmpl.ps1` and `afterbuild_task_unix.tmpl.sh`.
2. Depending on your current platform, choose one to create a copy in the directory and remove `.tmpl` from the file name. For example, if your current system is Windows, you should clone `afterbuild_task_win.tmpl.ps1` and rename it to `afterbuild_task_win.ps1`.
3. When `HandlerGenerator` completes the build, the full path of the generated Build folder will be passed into the script as the only parameter. You can then complete any tasks you want to complete by writing the script.
