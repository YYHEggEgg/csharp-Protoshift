# KcpPerformanceTest

本项目用于常规的网络协议（基于 KCP 的 mihoyonet）测试。

开启符号 `CONNECT_SERVERONLY` 以跳过中间代理，否则将会通过代理进行。

各项设置（包括 UDP 端口号）在 `Constants.cs` 中设置。

## 测试方法概述

测试由客户端生成一个奇数 ack，即 1,3,5,...；  
服务端收到对应 ack 后，将 ack +1 并将 body 原封不动重传；  
在此期间，三方将数据提交至统一的 Analysis 处理，分析速度、延迟、丢包等数据。

由于这套协议主要用于 Protobuf 传输，包数据只要有部分错误即视为全部丢包。

为了设计方便，此套测试程序仍使用 XOR 加密，但舍去了非对称密钥交换而只使用 dispatchKey.
