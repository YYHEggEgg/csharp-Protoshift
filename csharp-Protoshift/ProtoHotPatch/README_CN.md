[EN](README.md) | 中文

# Protoshift HotPatch

本文主要介绍为何要设计这个功能，基本的使用方法以及查错文档。

## 写在前面

游戏的制作商选择对自己的游戏进行混淆，这使得 proto dump 十分困难，dump 出来都是无意义的内容。读者大概已经知道了 nameTranslation 的概念，那么它是怎么得来的呢？

答案其实很简单：proto 在大部分情况下是不变的，只是数字变了一下；那么我们就可以通过两个版本的 proto 定义比对类型，找出正确的 nameTranslation。**混淆的过程本身确实是不可逆的。**

它大概依靠一种逻辑工作：先比对解出一些 nameTranslation，然后以这些 nameTranslation 再去解其他的 proto，以此类推，不断增加已知的信息。

但是，如果一些属性名称在程序中是唯一的呢？如果通过类型推断（比如所属 proto 已知，没有其他同类型的可能匹配）还可解，否则就是完全不可解了。在这种情况下，要是真的想解出来只有放弃幻想，在游戏内一个一个试。

本程序基于 json 的 Protoshift 版本曾实现过类似的功能，但缺陷颇多，而且完全不可迁移至新版的 protoshift。基于这种原因，在本分支删除了原有的实现并完全重新实现。

## 中间件设计

以一个例子解释中间件生效的时间：

1. 服务端向 Protoshift 代理服务器发送 `PlayerLoginRsp`。
2. 对应的 `HandlerSession` 收到包，解密后交给 `ProtoshiftDispatch`。
3. `ProtoshiftDispatch` 通过 CmdId 判断将其交给 `HandlerPlayerLoginRsp`。
4. `HandlerPlayerLoginRsp.OldShiftToNew` 将包 `oldprotocol` 转换为 `newprotocol`。
5. `OldShiftToNew` 将完整的 `oldprotocol` 和尚不完整的 `newprotocol` 交予 `HotPatchMiddleware`。
6. `HotPatchMiddleware` 检查到有针对 `PlayerLoginRsp` 的规则启用，从 `oldprotocol` 中查找规定字段，并将内容复制到 `newprotocol` 中，并返回 `newprotocol`。如果无规则启用则 `newprotocol` 原路返回。
7. `OldShiftToNew` 向上一路返回，直至 `HandlerSession`，其使用 `newprotocol` 重新组装新的包并传向客户端。

注意，`HotPatchMiddleware` 完全使用反射工作，性能开销较大。因此（也有实现上的原因），Proto HotPatch 目前限制：

- 只允许在 Debug 配置下运行。
- 只可以应用于 Protobuf message 中无法正常 Protoshift 的字段。注意，只要另一套 Proto 中存在名称相同且类型相同的字段，则视为字段已可以正常 Protoshift。程序并无能力判断 Proto 中的 field number 是否实际正确。

## Config 基本语法

在初次使用时，您需要将 `csharp-Protoshift/protoshift_hotpatch_config.tmpl.json` 复制到同目录下，并重命名为 `protoshift_hotpatch_config.json`，然后开始修改其内容。

config 采用 json 格式。它包含：

- 最外层一个数组，每个元素为一条 config。一般一个包（proto）一条 config。
- 内层每个元素填 `Proto`，`Enabled`，`ApplyTo`。特别注意 `ApplyTo` 填的是发包方。
- `Rules` 也是一个数组，有特殊的命名方式。

下面主要讲解 rule 的命名方式：

- `(name_from_protocol)->(name_to_protocol)`。意思是说，左边要填发包方 proto 的字段名，右边要填收包方 proto 中的字段名，中间以 `->` 连接。
- 这边不可以直接填字段名，必须填编译后的驼峰式。Protobuf 字段名的驼峰式是指将所有下划线后面的字母统一变为大写，同时首字母大写，例如字段名 `key_id` 在这里要填 `KeyId`，`Unk3300_AJBBIPFMBEL` 要变成 `Unk3300AJBBIPFMBEL`。
- 一般来讲，对于 `ApplyTo` 为 `Client` 的 config 来说，rule 的左边填乱码混淆名，右边填有意义字段名；反之亦然。
- 不可以包含类似递归的命名方式。例如：
  
  ```json
  [
    {
      "Proto": "ActivityInfoNotify",
      "ApplyTo": "server",
      "Enabled": false,
      "Rules": [
        // 这里的 nameTranslation 仅供参考。并非正确！
        "ActivityInfo/IsHidden->ActivityInfo/Unk3300MJNPGEKLOCG"
      ]
    }
  ]
  ```

  显然这是不可以允许的，应该新建对应 Proto 的规则：
  
  ```json
  [
    {
      "Proto": "ActivityInfo",
      "ApplyTo": "server",
      "Enabled": false,
      "Rules": [
        // 这里的 nameTranslation 仅供参考。并非正确！
        "IsHidden->Unk3300MJNPGEKLOCG"
      ]
    }
  ]
  ```

## Config 使用提醒

Config 支持最基础的检查。例如：

- 如果 json 不符合格式，所有的 Config 完全不会加载。  
  值得注意的是，如果已有成功加载的 config，其会被立即禁用。
- json 支持注释与尾随逗号。
- 如果某个规则没有通过可行性检查，其不会加载，已有规则也会被禁用。不会影响其他规则。

## Config 编译错误总览

- Error PSHP001: 尝试在 Release 环境下配置 HotPatch。
- Error PSHP002: json 格式解析失败，已卸载当前的 HotPatch 配置。
- Error PSHP003: 未找到对应的 Proto。_[弃用，与 PSHP004 合并]_
- Error PSHP004: Proto 未定义，或其不是两套 protocol 共有的。
- Error PSHP005: ApplyTo 字段不为 "client" 或 "server" 中的任何一个。
- Warning PSHP006: Config 已启用，但是 Rules 为空。
- Error PSHP007: rule 不包含标识符 `->`。
- Error PSHP008: rule 有一方的字段名为空。
- Error PSHP009: rule 至少有一方的字段名未定义，或其为一个可以正常被 Protoshift 的字段。
- Error PSHP010: 定义的 Proto 不存在无法正常 Protoshift 的字段。
- Warning PSHP011: 可能应翻转 rule 左右字段名。
- Warning PSHP012: rule 至少有一方可能应改为驼峰式命名。
- Error PSHP013: rule 两方类型不匹配。
- Error PSHP014: rule 中至少有一个字段不可以进行 Protoshift（因为其类型并不在两套 protocol 中共有）。
- Error PSHP015: rule 涉及到暂不支持的消息内定义的类型。_[暂时弃用]_
- Error PSHP016: 程序无法或无权读取文件，或文件被删除。
- Error PSHP017: 定义的 Proto 是一个枚举类型。
- Warning PSHP018: 字段名与消息名称相同，因此您可能需要在字段名后尾随下划线。请参考相应 Proto 编译后生成的代码。
- Error PSHP019: 所选的字段为一个 oneof 类型的入口点。应为 oneof 内的每个字段分别创建映射 rule。
- Error PSHP020: rule 包含多个标识符 `->`。
