---
name: Network Issue
about: KCP related issue
labels: network, kcp
---

Note: Asking in English can make your problem more widely known by the community, while asking in Chinese will make it handled more quickly by the repository owner. There is CN template version below, so you can choose one as you like.

说明：以英文提问可使你的问题更广泛由社区所了解，而以中文提问可以使仓库所有者更快跟进。下附有中文版模板，可据你的偏好自行选择一种。

------------------------------------

## Basic Information

Protoshift version:

## Problem Encountered

- [ ] Under certain circumstances, the server stops responding (and a KCP connection has not been successfully established)
- [ ] I am dissatisfied with the delay, TTL, and network fluctuations of the Network Protocol Stack, and have some optimization schemes
- [ ] There is severe delay or/and network fluctuation when the number of online clients is high
- [ ] I have reason to question that there are problems with the basic KCP implementation (slicing packet into Segment, Segment memory allocation, ordered packet transmission, thread safety, etc.)
- [ ] Other problems (please specify)

## Detailed Description of the Phenomenon and Server / `KcpPerformaceTest` Log

## Checklist

- [ ] I have searched for related issues in the issue area but have not resolved them
- [ ] I have browsed various Issue templates and confirmed that the current template is suitable for my problem
- [ ] I confirm that the issue I raised is related to the network protocol stack itself (and not dependent on other factors)
- [ ] I have run the building process properly
- [ ] I tried to run Protoshift and the game server on the same device
- [ ] I have attached necessary log records in the issue (you can also send them to `mihomo-technology@outlook.com`, making it disclosed after removing sensitive information). I also attached the necessary content of `latest.errtrace.log` (if an exception occurs).
- [ ] I confirm that the phenomenon is unrelated to the defects of my server (the real game server)
- [ ] **I am not running the server on any version of macOS, nor am I running the game client on iOS**

----------------------------------

## 基本信息

Protoshift 版本号：

## 遇到的问题

- [ ] 在特定情况下，服务器停止响应（且未成功建立 KCP 连接）
- [ ] 我对网络协议栈的延迟、TTL、网络波动不满意，并有一些优化方案
- [ ] 在客户端在线数量高时有严重的延迟/网络波动
- [ ] 我有理由质疑基础 KCP 的实现出现了问题（包切片、Segment 内存分配、有序包传输、线程安全等方面）
- [ ] 其他问题（请具体说明）

## 异常现象的具体说明与服务器 / `KcpPerformaceTest` 日志

## Checklist

- [ ] 我已在 issue 区寻找过相关的问题但未得到解决
- [ ] 我已浏览过多种 Issue 模板并确认当前模板适合我的问题
- [ ] 我确认提出的 issue 与网络协议栈本身有关（而不取决于其他因素）
- [ ] 我正确运行了生成
- [ ] 我尝试了将 Protoshift 与游戏服务器运行在同一台设备上
- [ ] 我已在 issue 中附带必要的日志记录（也可发送至 `mihomo-technology@outlook.com`，去除敏感信息后的部分将被公开）。我还附带了 `latest.errtrace.log` 的必要内容（如果有发生异常）。
- [ ] 我确认现象与我的服务器（真正的游戏服务器）的本身缺陷无关
- [ ] **我并非在 macOS 的任何版本上运行服务器，也并非在 iOS 上运行游戏客户端**
