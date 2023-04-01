#!/bin/sh
[ -z "$ZIG"] && ZIG="zig"
[ -z "$TARGET" ] && TARGET="x86_64-linux-gnu"
echo "$TARGET" | grep -q 'windows' && OUTPUT="ikcp.dll"
[ -z "$OUTPUT" ] && OUTPUT="libikcp.so"
zig cc -target $TARGET -shared ikcp.c -I. -o $OUTPUT -O2 -v
