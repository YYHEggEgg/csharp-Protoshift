# 定义变量
set WINDOWS_32="go-proto2json_win32.exe"
set WINDOWS_64="go-proto2json_win64.exe"
set MACOS_32="go-proto2json_mac32"
set MACOS_64="go-proto2json_mac64"
set LINUX_32="go-proto2json_linux32"
set LINUX_64="go-proto2json_linux64"

# build Windows 32-bit
echo "Building Windows 32-bit executable: $WINDOWS_32"
go env -w GOOS=windows GOARCH=386 
go build -o %WINDOWS_32% ./proto2json

# build Windows 64-bit
echo "Building Windows 64-bit executable: $WINDOWS_64"
go env -w GOOS=windows GOARCH=amd64 
go build -o %WINDOWS_64% ./proto2json

# build macOS 32-bit
echo "Building macOS 32-bit executable: $MACOS_32"
go env -w GOOS=darwin GOARCH=386 
go build -o %MACOS_32% ./proto2json

# build macOS 64-bit
echo "Building macOS 64-bit executable: $MACOS_64"
go env -w GOOS=darwin GOARCH=amd64 
go build -o %MACOS_64% ./proto2json

# build Linux 32-bit
echo "Building Linux 32-bit executable: $LINUX_32"
go env -w GOOS=linux GOARCH=386 
go build -o %LINUX_32% ./proto2json

# build Linux 64-bit
echo "Building Linux 64-bit executable: $LINUX_64"
go env -w GOOS=linux GOARCH=amd64 
go build -o %LINUX_64% ./proto2json

echo "Done"
