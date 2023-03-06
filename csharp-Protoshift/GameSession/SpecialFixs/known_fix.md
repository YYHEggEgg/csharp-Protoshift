# Known packets have bytes field to fix
This is a issue tree, and the parent node is where the issue come from.   
Only uses the root node as fixer_bytes. 

1. Bold lines refers to work done.
2. The bolded root nodes refers to _ISpecialBytesSkillIssueFixer_ finished.
3. The bolded leaf nodes refers to _ISpecialOuterSkillIssueFixer_ finished.
4. The other nodes in the middle may not be bolded.
5. Root nodes with `?` mean they're not confirmed whether they have skill issue to be fixed.
6. Nodes with delete lines mean they're duplicate with protos that have appeared below.

- **AbilityInvokeEntry**
  - **AbilityInvocationFailNotify**
  - ~~AbilityInvocationFixedNotify~~
  - **AbilityInvocationsNotify**
  - **ClientAbilityChangeNotify**
  - **ClientAbilityInitFinishNotify**
  - EntityAbilityInvokeEntry
    - **ClientAbilitiesInitFinishCombineNotify**
- CombatInvokeEntry
  - CombatInvocationsNotify
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