---
name: Optimition Request
about: Request for optimitions or features
label: enhancement
---

Note: Asking in English can make your problem more widely known by the community, while asking in Chinese will make it handled more quickly by the repository owner. There is CN template version below, so you can choose one as you like.

说明：以英文提问可使你的问题更广泛由社区所了解，而以中文提问可以使仓库所有者更快跟进。下附有中文版模板，可据你的偏好自行选择一种。

------------------------------------

## Basic Information

Protoshift version number:
Server OS in use:
Client OS:
Server Protobuf version (branch of OldProtos):
Client Protobuf version (branch of NewProtos):

## Requested Optimization Scheme

- [ ] I have a feasible plan for optimizing the maintainability of the existing code
- [ ] I want to make Protoshift or HandlerGenerator support new features to make it easier to use
- [ ] I believe that the Protoshift server needs and can perform JIT compilation of all Handlers at startup
- [ ] I want to contribute to text localization solutions
- [ ] I want Windy to automatically run with more complex logic
- [ ] I intend to promote smarter UDP packet (KCP handshake packet) forwarding, rate control and other network optimization schemes
- [ ] I believe that ProtoHotPatch can introduce more complex process control (such as directly introducing external processing code at runtime) or relax restrictions (the existing restriction is that only Protos with unrecognized fields can perform ProtoHotPatch)
- [ ] I believe that HandlerGenerator can be specifically optimized to shorten the time of build process
- [ ] I believe that a better asynchronous model can be designed for the KCP or Proxy protocol layer
- [ ] Other optimizations or features (please specify)

## Checklist

- [ ] I have browsed various Issue templates and confirmed that the current template is suitable for my problem
- [ ] I confirm that the requirement is an improvement rather than a bug fix
- [ ] I confirm that it will not reduce the availability of the Protoshift server
- [ ] I confirm that the phenomenon can be removed from any external factors (such as Windy, cheats, specific GM commands, or custom server data), or I have publicly disclosed these external and deployment methods in the main body of the issue
- [ ] If the text proposes a specific implementation, I confirm that it can be used cross-platform

------------------------------------

## 基本信息

Protoshift 版本号：
服务器使用 OS：
客户端 OS：
服务器 Protobuf 版本（OldProtos 的分支）：
客户端 Protobuf 版本（NewProtos 的分支）：

## 请求的优化方案

- [ ] 我有对于现有代码可维护性优化的可行方案
- [ ] 我想使 Protoshift 或 HandlerGenerator 支持新功能以使其更易于使用
- [ ] 我认为 Protoshift 服务器有必要并且可以做到在启动时执行全部 Handler 的 JIT 编译
- [ ] 我想贡献文本本地化方案
- [ ] 我想要 Windy 自动化运行带有更复杂的逻辑
- [ ] 我意图推行更智能的 UDP 包（KCP 握手包）转发、速率控制等网络优化方案
- [ ] 我认为 ProtoHotPatch 可以引入更复杂的流程控制（例如直接运行时引入外部处理代码）或放宽限制（现有限制为只有具有未识别字段的 Proto 才可进行 ProtoHotPatch）
- [ ] 我认为 HandlerGenerator 可以进行特定优化以缩短重新生成的时间
- [ ] 我认为可以为 KCP 或 Proxy 协议层设计更好的异步模型
- [ ] 其他优化或特性（请具体说明）

## Checklist

- [ ] 我已浏览过多种 Issue 模板并确认当前模板适合我的问题
- [ ] 我确认需求的是一个改进而不是一种针对 bug 的修复
- [ ] 我确认其不会降低 Protoshift 服务器的可用性
- [ ] 我确认现象可以在去除任何外置因素（如 Windy、外挂、特定 GM 命令、或定制版服务器等），或我已在 issue 主体中公开这些外置与部署方法
- [ ] 如果正文提出了具体实现，我确认其可以跨平台使用
