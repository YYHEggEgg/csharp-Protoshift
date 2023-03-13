# ConcurrentUdpClient

代码由 CharGPT 生成，以下是生成使用的问题。

```
接下来，你需要根据我的描述，对C#的UdpClient类进行封装，制作一个UdpClientWrapper类。
首先，定义一个内部结构体UdpSendPacket，包含以下字段：
byte[] data 和 IPEndPoint endpoint，分别表示发包的字节数与远程主机。
接着，在ConcurrentUdpClient类内部定义三个私有字段：
ConcurrentQueue<UdpSendPacket> qSend 、
ConcurrentQueue<(UdpReceiveResult, Exception?)> qRecv和UdpClient baseClient，
分别表示发包队列、收包队列与内部使用的UdpClient实例。

然后定义方法：void Send(byte[], IPEndpoint)，它将输入参数转换成UdpSendPacket实例并插入qSend队列。
类似的，定义方法：async Task<UdpReceiveResult> ReceiveAsync()，它将持续尝试从qRecv将一个UdpReceiveResult出队，出队成功后将该实例返回。
为类定义一个无参构造器，其初始化qSend、qRecv与baseClient，并在后台运行一个异步方法BackgroundUpdate()：
它将会以递归方式循环执行，执行以下操作：
当qSend非空时，将队列最前元素出队，调用baseClient.SendAsync(byte[], int, IPEndPoint)方法执行发包操作，如果发生异常则将取出的UdpSendPacket加入队列末尾；
当qSend为空时，如果baseClient.Avaliable非0则尝试调用baseClient.ReceiveAsync()收包，将返回值（UdpReceiveResult）或发生的异常加入qRecv。如果在100ms内没有收到包则取消该任务。
此外，在代码中你需要始终遵循以下原则：
总是遵循我的描述编写代码；
在代码中添加尽量详尽的注释；
在所有对于baseClient的调用中添加异常处理程序，如果我没有提到怎样实现则留空。
```