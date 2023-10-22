name: Windy Issue
about: Issues related to windy script (remote lua) execution
labels: bug, windy
---

Note: Asking in English can make your problem more widely known by the community, while asking in Chinese will make it handled more quickly by the repository owner. There is CN template version below, so you can choose one as you like.

说明：以英文提问可使你的问题更广泛由社区所了解，而以中文提问可以使仓库所有者更快跟进。下附有中文版模板，可据你的偏好自行选择一种。

## Basic Information

- Protoshift version:
- Server OS:
- Client OS:

## Problem Encountered

- [ ] The client is expected to run the lua script (windy was sent) but it did not take effect
- [ ] Running a specific lua script causes the entire game to crash
- [ ] The effect of running the lua script is significantly different from the effect produced by other builds (performance issue issues are not included)
- [ ] The server (should be able to but) cannot compile a specific lua script
- [ ] There are problems with the remote execution of the lua script **after the server reuses the compilation (such as restarting the program)** (which is related to runtime/program reloading)
- [ ] Other problems (please specify)

## Detailed Description of the Phenomenon

## The original lua script that caused the exception (and server log)

## Checklist

- [ ] I have searched for related issues in the issue area but have not resolved them
- [ ] I have browsed various Issue templates and confirmed that the current template is suitable for my problem
- [ ] I confirm that the issue I raised is related to Windy (and not dependent on other factors)
- [ ] I have attached necessary log records in the issue (you can also send them to `mihomo-technology@outlook.com`, making it disclosed after removing sensitive information). I also attached the necessary content of `latest.errtrace.log` (if an exception occurs).
- [ ] I used [the luac compiler provided in the repository](https://github.com/YYHEggEgg/csharp-Protoshift/tree/main/csharp-Protoshift/resources/luac_bins) or another compiler that can be proven to be compatible with the anime game
- [ ] I confirm that the lua script itself complies with `Lua 5.3.5` syntax, and does not include operations that `xlua` may prohibit, such as reading files (required by import modules)
- [ ] **I am not running the server on any version of macOS, nor am I running the game client on iOS**

-----------------------------------------


## 基本信息

- Protoshift 版本号：
- 服务器使用 OS：
- 客户端 OS：

## 遇到的问题

- [ ] 要求客户端运行 lua 脚本（发送了 windy）却未产生效果
- [ ] 客户端运行特定 lua 脚本导致整个游戏闪退
- [ ] 客户端运行 lua 脚本与其他 build 产生的效果存在显著差异（性能问题 issue 不包括在内）
- [ ] 服务端（本应可以却）无法编译特定的 lua 脚本
- [ ] 服务端**重用编译（如重启程序）后** lua 脚本远程执行存在问题（该问题与运行时/程序重新加载相关）
- [ ] 其他问题（请具体说明）

## 异常现象的具体说明

## 引发异常的 lua 原脚本（与服务器日志）

## Checklist

- [ ] 我已在 issue 区寻找过相关的问题但未得到解决
- [ ] 我已浏览过多种 Issue 模板并确认当前模板适合我的问题
- [ ] 我确认提出的 issue 与 Windy 有关（而不取决于其他因素）
- [ ] 我已在 issue 中附带必要的日志记录（也可发送至 `mihomo-technology@outlook.com`，去除敏感信息后的部分将被公开）。我还附带了 `latest.errtrace.log` 的必要内容（如果有发生异常）。
- [ ] 我使用 [存储库中打包提供的 luac 编译器](https://github.com/YYHEggEgg/csharp-Protoshift/tree/main/csharp-Protoshift/resources/luac_bins) 或可证明与某二游相兼容的其他编译器
- [ ] 我确认 lua 脚本本身符合 `Lua 5.3.5` 的语法，并且不包含读取文件（如 import 模块）等 `xlua` 可能禁止的操作
- [ ] **我并非在 macOS 的任何版本上运行服务器，也并非在 iOS 上运行游戏客户端**
