# Known packets have bytes field to fix

## Introduction
It mainly solve the 'bytes' problem.
In some packets, for unknown purposes, the anime game send original protobuf bin data as 'bytes', and along with any fields describe its protocol information.
Though never could we know why they don't use oneof, we can do no more than adjust to it.

## Fix process info
This is a issue tree, and the parent node is where the issue come from.   
In the protoshift-ex version, only the root nodes directly have bytes field and should implement Special handlers. 

1. Bold lines refers to work done.
2. The bolded root nodes refers to SpecialHandlers implemented.
4. The other nodes may not be bolded.
5. Root nodes with `?` mean they're not confirmed whether they have skill issue to be fixed.
6. Nodes with ~~delete lines~~ mean they're duplicate with protos that have appeared below.

- **AbilityInvokeEntry**
  - AbilityInvocationFailNotify
  - AbilityInvocationFixedNotify
  - AbilityInvocationsNotify
  - ClientAbilityChangeNotify
  - ClientAbilityInitFinishNotify
  - EntityAbilityInvokeEntry
    - ClientAbilitiesInitFinishCombineNotify
- **CombatInvokeEntry**
  - CombatInvocationsNotify
- **UnionCmd**
  - UnionCmdNotify
- BlockInfo?
  - FeatureBlockInfo
    - PlayerLoginRsp
  - ~~PlayerLoginRsp~~
- HomeBlockDotPattern?
  - HomeBlockArrangementInfo
    - HomeSceneArrangementInfo
      - HomeCreateBlueprintReq
      - HomeGetArrangementInfoRsp
      - HomePreviewBlueprintRsp
      - HomeUpdateArrangementInfoReq
- PlayerInjectFixNotify?