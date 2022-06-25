// @generated by protobuf-ts 2.7.0 with parameter client_grpc1
// @generated from protobuf file "Server/Rpc/Room.proto" (syntax proto3)
// tslint:disable
import { RoomService } from "./Room";
import type { BinaryWriteOptions } from "@protobuf-ts/runtime";
import type { BinaryReadOptions } from "@protobuf-ts/runtime";
import type { JoinRoomRequest } from "./Room";
import type { CreateRoomResponse } from "./Room";
import type { Empty } from "../../google/protobuf/empty";
import * as grpc from "@grpc/grpc-js";
/**
 * @generated from protobuf service RoomService
 */
export interface IRoomServiceClient {
    /**
     * @generated from protobuf rpc: CreateRoom(google.protobuf.Empty) returns (CreateRoomResponse);
     */
    createRoom(input: Empty, metadata: grpc.Metadata, options: grpc.CallOptions, callback: (err: grpc.ServiceError | null, value?: CreateRoomResponse) => void): grpc.ClientUnaryCall;
    createRoom(input: Empty, metadata: grpc.Metadata, callback: (err: grpc.ServiceError | null, value?: CreateRoomResponse) => void): grpc.ClientUnaryCall;
    createRoom(input: Empty, options: grpc.CallOptions, callback: (err: grpc.ServiceError | null, value?: CreateRoomResponse) => void): grpc.ClientUnaryCall;
    createRoom(input: Empty, callback: (err: grpc.ServiceError | null, value?: CreateRoomResponse) => void): grpc.ClientUnaryCall;
    /**
     * @generated from protobuf rpc: JoinRoom(JoinRoomRequest) returns (google.protobuf.Empty);
     */
    joinRoom(input: JoinRoomRequest, metadata: grpc.Metadata, options: grpc.CallOptions, callback: (err: grpc.ServiceError | null, value?: Empty) => void): grpc.ClientUnaryCall;
    joinRoom(input: JoinRoomRequest, metadata: grpc.Metadata, callback: (err: grpc.ServiceError | null, value?: Empty) => void): grpc.ClientUnaryCall;
    joinRoom(input: JoinRoomRequest, options: grpc.CallOptions, callback: (err: grpc.ServiceError | null, value?: Empty) => void): grpc.ClientUnaryCall;
    joinRoom(input: JoinRoomRequest, callback: (err: grpc.ServiceError | null, value?: Empty) => void): grpc.ClientUnaryCall;
}
/**
 * @generated from protobuf service RoomService
 */
export class RoomServiceClient extends grpc.Client implements IRoomServiceClient {
    private readonly _binaryOptions: Partial<BinaryReadOptions & BinaryWriteOptions>;
    constructor(address: string, credentials: grpc.ChannelCredentials, options: grpc.ClientOptions = {}, binaryOptions: Partial<BinaryReadOptions & BinaryWriteOptions> = {}) {
        super(address, credentials, options);
        this._binaryOptions = binaryOptions;
    }
    /**
     * @generated from protobuf rpc: CreateRoom(google.protobuf.Empty) returns (CreateRoomResponse);
     */
    createRoom(input: Empty, metadata: grpc.Metadata | grpc.CallOptions | ((err: grpc.ServiceError | null, value?: CreateRoomResponse) => void), options?: grpc.CallOptions | ((err: grpc.ServiceError | null, value?: CreateRoomResponse) => void), callback?: ((err: grpc.ServiceError | null, value?: CreateRoomResponse) => void)): grpc.ClientUnaryCall {
        const method = RoomService.methods[0];
        return this.makeUnaryRequest<Empty, CreateRoomResponse>(`/${RoomService.typeName}/${method.name}`, (value: Empty): Buffer => Buffer.from(method.I.toBinary(value, this._binaryOptions)), (value: Buffer): CreateRoomResponse => method.O.fromBinary(value, this._binaryOptions), input, (metadata as any), (options as any), (callback as any));
    }
    /**
     * @generated from protobuf rpc: JoinRoom(JoinRoomRequest) returns (google.protobuf.Empty);
     */
    joinRoom(input: JoinRoomRequest, metadata: grpc.Metadata | grpc.CallOptions | ((err: grpc.ServiceError | null, value?: Empty) => void), options?: grpc.CallOptions | ((err: grpc.ServiceError | null, value?: Empty) => void), callback?: ((err: grpc.ServiceError | null, value?: Empty) => void)): grpc.ClientUnaryCall {
        const method = RoomService.methods[1];
        return this.makeUnaryRequest<JoinRoomRequest, Empty>(`/${RoomService.typeName}/${method.name}`, (value: JoinRoomRequest): Buffer => Buffer.from(method.I.toBinary(value, this._binaryOptions)), (value: Buffer): Empty => method.O.fromBinary(value, this._binaryOptions), input, (metadata as any), (options as any), (callback as any));
    }
}
