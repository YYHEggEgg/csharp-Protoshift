protoc --proto_path="NewProtoHandlers\Google.Protobuf\Protos" "NewProtoHandlers\Google.Protobuf\Protos\*.proto" --csharp_out="NewProtoHandlers\Google.Protobuf\Compiled"
protoc --proto_path="OldProtoHandlers\Google.Protobuf\Protos" "OldProtoHandlers\Google.Protobuf\Protos\*.proto" --csharp_out="OldProtoHandlers\Google.Protobuf\Compiled"