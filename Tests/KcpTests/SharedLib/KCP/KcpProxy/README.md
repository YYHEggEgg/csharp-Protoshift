## About this
KCP Proxy is not as simple as something like "I have a client and a server, then just transfer it". They actually have a inner connection -- at least keep Conv and Token the same.  

The full implement is like the picture below.   
Summary: KcpProxyServer (implements KCPServer) -> KcpProxy (implements KCP) -> KcpProxyClient (implements KCPClient) -> KCP

![Implements](https://raw.githubusercontent.comYYHEggEgg/csharp-Protoshift/main/KCP/KcpProxy/AnimeGame_KcpProxy.png)