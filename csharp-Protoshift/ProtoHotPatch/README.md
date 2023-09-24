# Protoshift HotPatch

This document mainly introduces why this feature is designed, the basic usage method, and the error checking document.

## Preface

The anime game company chooses to obfuscate their game, which makes proto dump very difficult, and the dumped content is meaningless. Readers probably already know the concept of nameTranslation, so how did it come about?

The answer is actually very simple: proto is unchanged in most cases, just the numbers have changed; then we can compare the types of two versions of proto definitions to find the correct nameTranslation. **The process of obfuscation itself is indeed irreversible.**

It probably relies on a logic: first compare and solve some nameTranslations, and then use these nameTranslations to solve other protos, and so on, constantly increasing known information.

However, what if some attribute names are unique in the program? If it can be solved by type inference (for example, the belonging proto is known, and there is no other possible match of the same type), otherwise it is completely unsolvable. In this case, if you really want to solve it, you have to give up the automatic process and try one by one in the game.

One of this program's versions that based on json's Protoshift has implemented similar functions, but there are many defects, and it cannot be migrated to the new version of protoshift at all. For this reason, the original implementation was deleted in this branch and completely re-implemented.

## Middleware Design

Explain the time when the middleware takes effect with an example:

1. The server sends `PlayerLoginRsp` to the Protoshift proxy.
2. The corresponding `HandlerSession` receives the package, decrypts it and gives it to `ProtoshiftDispatch`.
3. `ProtoshiftDispatch` judges to give it to `HandlerPlayerLoginRsp` through CmdId.
4. `HandlerPlayerLoginRsp.OldShiftToNew` converts the package `oldprotocol` to `newprotocol`.
5. `OldShiftToNew` gives the complete `oldprotocol` and the incomplete `newprotocol` to `HotPatchMiddleware`.
6. `HotPatchMiddleware` notices that there are rules for `PlayerLoginRsp` enabled, so finds the specified fields from `oldprotocol`, and copies the content to `newprotocol`, and returns `newprotocol`. If no rules are enabled, `newprotocol` will be returned the same way.
7. `OldShiftToNew` returns all the way up to `HandlerSession`, which uses `newprotocol` to reassemble a new package and send it to the client.

Note that `HotPatchMiddleware` works entirely by reflection, so the performance overhead is large.

## Basic Syntax of Config

The config uses the json format. It includes:

- The outermost layer is an array, each element is a config. Generally, we assign one config for each proto.
- The inner layer fills `Proto`, `Enabled`, `ApplyTo`. Pay special attention to `ApplyTo` is the sender.
- `Rules` is also an array, with a special naming method.

The following mainly explains the naming method of rule:

- `(name_from_protocol)->(name_to_protocol)`. It means that the left side should fill in the field name of the sender's proto, and the right side should fill in the field name in the receiver's proto, connected by `->`.
- You can't directly fill in the field name here, but you must fill in the compiled camel case. The camel case of the Protobuf field name refers to changing all the letters after the underscore to uppercase, and the first letter is uppercase. For example, the field name `key_id` should be filled in here as `KeyId`, and `Unk3300_AJBBIPFMBEL` should be changed to `Unk3300AJBBIPFMBEL`.
- Generally speaking, for configs with `ApplyTo` as `Client`, the left side of the rule fills in the garbled obfuscated name, and the right side fills in the meaningful field name; vice versa.
- Cannot contain recursive naming methods. For example:

  ```json
  [
    {
      "Proto": "ActivityInfoNotify",
      "ApplyTo": "server",
      "Enabled": false,
      "Rules": [
        // The nameTranslation here is for reference only. Not correct!
        "ActivityInfo/IsHidden->ActivityInfo/Unk3300MJNPGEKLOCG"
      ]
    }
  ]
  ```

  Obviously this is not allowed, and you should create corresponding Proto rules directly:

  ```json
  [
    {
      "Proto": "ActivityInfo",
      "ApplyTo": "server",
      "Enabled": false,
      "Rules": [
        // The nameTranslation here is for reference only. Not correct!
        "IsHidden->Unk3300MJNPGEKLOCG"
      ]
    }
  ]
  ```

## Config Usage Reminder

Config supports the most basic checks. For example:

- If the json does not conform to the format, all Configs will not load.  
  It is worth noting that if there is a successfully loaded config, it will be immediately disabled. You can use the `kskillissue revert` command to overwrite and restore file changes and reload, but if you do not run the `revert` command, the content of the previous version of the config will be discarded when the server is closed.
- json supports comments.
- If a rule does not pass the feasibility check, it will not load, and existing rules will be disabled. Will not affect other rules.

## Overview of Config Compilation Errors

- Error PSHP001: Try to configure HotPatch in the Release environment.
- Error PSHP002: json format parsing failed, and the current HotPatch configuration has been unloaded.
- Error PSHP003: The corresponding Proto was not found. _[Obsoleted, merged to PSHP004]_
- Error PSHP004: Proto is undefined, or not common to the two protocols.
- Error PSHP005: The ApplyTo field is not any of "client" or "server".
- Warning PSHP006: Config is enabled, but Rules is empty.
- Error PSHP007: rule does not contain the identifier `->`.
- Error PSHP008: One side of the rule has an empty field name.
- Error PSHP009: At least one side of the rule field name is undefined, or can be already Protoshifted normally.
- Error PSHP010: The defined Proto does not exist and cannot be Protoshifted correctly.
- Warning PSHP011: The left and right field names of the rule may need to be reversed.
- Warning PSHP012: At least one side of the rule may need to be changed to camel case.
- Error PSHP013: The types of the two sides of the rule do not match.
- Error PSHP014: At least one field in the rule cannot be Protoshifted (because its type is not common in the two protocols).
- Error PSHP015: The rule involves types defined in messages that are not currently supported. _[Obsoleted temporarily]_
- Error PSHP016: The program cannot or has no right to read the file, or the file has been deleted.
- Error PSHP017: The defined Proto is an protobuf enum.
- Warning PSHP018: The field name is the same as the message name, so you may need to follow an underscore after the field name. Please refer to the code generated after the corresponding Proto is compiled.
- Error PSHP019: The selected field is an entry point of a oneof field. Mapping rules should be created for each field within oneof.
- Error PSHP020: The left field of the rule does not exist.
