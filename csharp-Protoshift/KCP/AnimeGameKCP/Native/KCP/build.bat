@echo off
set ZIG=zig
set TARGET=x86_64-windows-gnu
%ZIG% cc -target %TARGET% ikcp.c -shared -o ikcp.dll -O2
