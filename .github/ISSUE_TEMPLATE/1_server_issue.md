---
name: Server Running Issue
about: Issues of server running
labels: bug, server
---

Note: Asking in English can make your problem more widely known by the community, while asking in Chinese will make it handled more quickly by the repository owner. There is CN template version below, so you can choose one as you like.

说明：以英文提问可使你的问题更广泛由社区所了解，而以中文提问可以使仓库所有者更快跟进。下附有中文版模板，可据你的偏好自行选择一种。

------------------------------------

## Basic Information

Protoshift version:
Server OS:
Client OS:

## Problem Encountered

- [ ] Under certain circumstances, the server stops responding (but a KCP connection has been established)
- [ ] The server indicates a fatal error and stops running
- [ ] The effect of Protoshift HotPatch is not as expected, or it sends out wrong warnings/errors
- [ ] Other problems (please specify)

## Detailed Description of the Phenomenon

## Server Log When the Exception Occurs

## Checklist

- [ ] I have searched for related issues in the issue area but have not resolved them
- [ ] I have browsed various Issue templates and confirmed that the current template is suitable for my problem
- [ ] I confirm that the issue I raised is related to the Protoshift server itself (and not dependent on other factors)
- [ ] I have run the building process properly
- [ ] I have attached necessary log records in the issue (you can also send them to `mihomo-technology@outlook.com`, making it disclosed after removing sensitive information). I also attached the necessary content of `latest.errtrace.log` (if an exception occurs).
- [ ] I confirm that I have not included `latest.packet.log` in the main body of the issue, or it has removed GetPlayerTokenReq(Rsp), PlayerLoginReq(Rsp) (to avoid leaking private information).
- [ ] I confirm that the phenomenon is unrelated to the defects of my server (the real game server)
- [ ] **I am not running the server on any version of macOS, nor am I running the game client on iOS**

------------------------------------

## 基本信息

Protoshift 版本号：
服务器使用 OS：
客户端 OS：

## 遇到的问题

- [ ] 在特定情况下，服务器停止响应（但建立了 KCP 连接）
- [ ] 服务器提示发生了致命错误且停止运行
- [ ] Protoshift HotPatch 效果未达预期，或发出错误的警告/错误
- [ ] 其他问题（请具体说明）

## 异常现象的具体说明

## 引发异常时的服务器日志

## Checklist

- [ ] 我已在 issue 区寻找过相关的问题但未得到解决
- [ ] 我已浏览过多种 Issue 模板并确认当前模板适合我的问题
- [ ] 我确认提出的 issue 与 Protoshift 服务器本身有关（而不取决于其他因素）
- [ ] 我正确运行了生成
- [ ] 我已在 issue 中附带必要的日志记录（也可发送至 `mihomo-technology@outlook.com`，去除敏感信息后的部分将被公开）。我还附带了 `latest.errtrace.log` 的必要内容（如果有发生异常）。
- [ ] 我确认没有将 `latest.packet.log` 包含在 issue 主体中，或其去除了 GetPlayerTokenReq(Rsp), PlayerLoginReq(Rsp)（以避免泄露隐私信息）。
- [ ] 我确认现象与我的服务器（真正的游戏服务器）的本身缺陷无关
- [ ] **我并非在 macOS 的任何版本上运行服务器，也并非在 iOS 上运行游戏客户端**
