## About this

This directory has the same usage with that in `ProtoshiftHandlers/Generated`.

The main difference is: this directory is used to contain Handlers **with SKILL ISSUE**.

If a protocol is detected skill issue when compiling Handlers, it will be added here, or it will be added to ProtoshiftHandlers.  

The main advantage for adding handlers to the main executable is that you can fix skill issues during the RUNTIME using Hot Reload. (Visual Studio highly recommended!)

For other protocols, putting it to another library can ease the compile pressure.

They will share the same namespace. Currently.