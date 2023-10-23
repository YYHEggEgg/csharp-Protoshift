Generally, resource files are placed in the `csharp-Protoshift/resources` directory. When exporting a single release version, this folder will also be copied to the program directory.

The following content is sorted by the necessity of personalization (from large to small).

## `xor` Folder

Different servers are likely to use different dispatchKeys, so it is recommended that you fully execute the following steps to ensure that the program can run correctly.

1. Find the existing files of `dispatchSeed.bin` and `dispatchKey.bin` used by your server. This is obviously the easiest method, which can save a lot of trouble. If found, replace the existing files under `resources/xor` with these files.
2. If you cannot find the corresponding files, please run the build first, and then run `./run --utils-only` to start in tool command mode only. They may be used in the following text.
3. You can go to your database to find content, such as the content of the `server_secret_key` field (if any). If the exported content is a HEX string, you may need to use a hexadecimal editor to write the content to the file; if the exported content is a base64 string, you can refer to the [util `convert` command](EN_Commands#convert-command) to convert it to a HEX string.
4. If you can't do the previous step, please send a valid `query_cur_region` request to your server, copy the response body, and run the [util `dcurr` command](EN_Commands#dcurr-command).  
   After obtaining the decrypted JSON, please find the field named `clientSecretKeyEncrypted` in it, which is the base64 format `client_secret_key`. Use the [util `convert` command](EN_Commands#convert-command) to convert it to a HEX string, and then use a hexadecimal editor to write the converted content to `resources/xor/dispatchSeed.bin`.
5. After the above steps are completed, even if you only have `dispatchSeed.bin`, you should be able to start the server, but you may receive a warning. If you want to remove the warning, you can use the [util `ec2b` command](EN_Commands#ec2b-command) to generate `server_secret_key` and use a hexadecimal editor to write to `resources/xor/dispatchKey.bin`.

## `windy-scripts` Folder

This is the default lua environment path, where you can store lua scripts running windy. For more information about windy, please refer to the [`windy` command](EN_Commands#windy-command).

## `rsakeys` Folder

It contains the `ClientPri` and `ServerPri` folders.

Generally speaking, you don't need to change the files in `ClientPri`. And if you have generated your own `server_private_key`, you should also know how to configure the content in the `ServerPri` folder, so these contents are omitted here. In most cases, the `server_private_key` you use is the GC Key, so no operation is required.

You can configure the `ServerPub` key specifically for the [util `dcurr` command](EN_Commands#dcurr-command), which is used to verify the signature of the content when decrypting `query_cur_region`. **You still need the `ServerPri` key to run the server**, which means that you cannot use this Protoshift implementation as a proxy capture software for servers that you do not control.

## `luac_bins` Folder

This is where the default distributed luac compiler for Windy is stored.

It is recommended not to change. If you want to use your own luac compiler, it is recommended that you specify other paths on your local computer in `config.json`.

## `config-schemas` Folder

It contains the JSON Schema of `config.json` used by the program. The program needs to use the files in it to ensure that the provided `config.json` complies with the configuration.

Generally speaking, for compatibility reasons, a version of the config JSON Schema should not be changed after it is officially released.

## `protobuf` Folder

Here you used to manually fill in `oldcmdid.csv` and `newcmdid.csv`, but now it is automatically managed by the `HandlerGenerator` build process.

Should not be changed manually.
