 protoc-21.1-win64/bin/protoc.exe  --proto_path=./Protos/ --csharp_out=./Generated/CS/ --csharp_opt=base_namespace=RabiRiichi.Generated $(find ./Protos/ -iname "*.proto")