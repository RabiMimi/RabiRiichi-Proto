// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Server/Messages/Inquiry.proto" (syntax proto3)
// tslint:disable
import type { BinaryWriteOptions } from "@protobuf-ts/runtime";
import type { IBinaryWriter } from "@protobuf-ts/runtime";
import { WireType } from "@protobuf-ts/runtime";
import type { BinaryReadOptions } from "@protobuf-ts/runtime";
import type { IBinaryReader } from "@protobuf-ts/runtime";
import { UnknownFieldHandler } from "@protobuf-ts/runtime";
import type { PartialMessage } from "@protobuf-ts/runtime";
import { reflectionMergePartial } from "@protobuf-ts/runtime";
import { MESSAGE_TYPE } from "@protobuf-ts/runtime";
import { MessageType } from "@protobuf-ts/runtime";
import { SinglePlayerInquiryMsg } from "../../Actions/SinglePlayerInquiry";
/**
 * @generated from protobuf message ServerInquiryMsg
 */
export interface ServerInquiryMsg {
    /**
     * @generated from protobuf field: int32 id = 1;
     */
    id: number;
    /**
     * @generated from protobuf field: SinglePlayerInquiryMsg inquiry = 2;
     */
    inquiry?: SinglePlayerInquiryMsg;
}
/**
 * @generated from protobuf message ServerInquiryEndMsg
 */
export interface ServerInquiryEndMsg {
    /**
     * @generated from protobuf field: int32 id = 1;
     */
    id: number;
    /**
     * @generated from protobuf field: int32 end_id = 2;
     */
    endId: number;
}
/**
 * @generated from protobuf message ClientInquiryMsg
 */
export interface ClientInquiryMsg {
    /**
     * @generated from protobuf field: int32 id = 1;
     */
    id: number;
    /**
     * @generated from protobuf field: int32 index = 2;
     */
    index: number;
    /**
     * @generated from protobuf field: bytes response = 3;
     */
    response: Uint8Array;
}
// @generated message type with reflection information, may provide speed optimized methods
class ServerInquiryMsg$Type extends MessageType<ServerInquiryMsg> {
    constructor() {
        super("ServerInquiryMsg", [
            { no: 1, name: "id", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "inquiry", kind: "message", T: () => SinglePlayerInquiryMsg }
        ]);
    }
    create(value?: PartialMessage<ServerInquiryMsg>): ServerInquiryMsg {
        const message = { id: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<ServerInquiryMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: ServerInquiryMsg): ServerInquiryMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 id */ 1:
                    message.id = reader.int32();
                    break;
                case /* SinglePlayerInquiryMsg inquiry */ 2:
                    message.inquiry = SinglePlayerInquiryMsg.internalBinaryRead(reader, reader.uint32(), options, message.inquiry);
                    break;
                default:
                    let u = options.readUnknownField;
                    if (u === "throw")
                        throw new globalThis.Error(`Unknown field ${fieldNo} (wire type ${wireType}) for ${this.typeName}`);
                    let d = reader.skip(wireType);
                    if (u !== false)
                        (u === true ? UnknownFieldHandler.onRead : u)(this.typeName, message, fieldNo, wireType, d);
            }
        }
        return message;
    }
    internalBinaryWrite(message: ServerInquiryMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 id = 1; */
        if (message.id !== 0)
            writer.tag(1, WireType.Varint).int32(message.id);
        /* SinglePlayerInquiryMsg inquiry = 2; */
        if (message.inquiry)
            SinglePlayerInquiryMsg.internalBinaryWrite(message.inquiry, writer.tag(2, WireType.LengthDelimited).fork(), options).join();
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message ServerInquiryMsg
 */
export const ServerInquiryMsg = new ServerInquiryMsg$Type();
// @generated message type with reflection information, may provide speed optimized methods
class ServerInquiryEndMsg$Type extends MessageType<ServerInquiryEndMsg> {
    constructor() {
        super("ServerInquiryEndMsg", [
            { no: 1, name: "id", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "end_id", kind: "scalar", T: 5 /*ScalarType.INT32*/ }
        ]);
    }
    create(value?: PartialMessage<ServerInquiryEndMsg>): ServerInquiryEndMsg {
        const message = { id: 0, endId: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<ServerInquiryEndMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: ServerInquiryEndMsg): ServerInquiryEndMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 id */ 1:
                    message.id = reader.int32();
                    break;
                case /* int32 end_id */ 2:
                    message.endId = reader.int32();
                    break;
                default:
                    let u = options.readUnknownField;
                    if (u === "throw")
                        throw new globalThis.Error(`Unknown field ${fieldNo} (wire type ${wireType}) for ${this.typeName}`);
                    let d = reader.skip(wireType);
                    if (u !== false)
                        (u === true ? UnknownFieldHandler.onRead : u)(this.typeName, message, fieldNo, wireType, d);
            }
        }
        return message;
    }
    internalBinaryWrite(message: ServerInquiryEndMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 id = 1; */
        if (message.id !== 0)
            writer.tag(1, WireType.Varint).int32(message.id);
        /* int32 end_id = 2; */
        if (message.endId !== 0)
            writer.tag(2, WireType.Varint).int32(message.endId);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message ServerInquiryEndMsg
 */
export const ServerInquiryEndMsg = new ServerInquiryEndMsg$Type();
// @generated message type with reflection information, may provide speed optimized methods
class ClientInquiryMsg$Type extends MessageType<ClientInquiryMsg> {
    constructor() {
        super("ClientInquiryMsg", [
            { no: 1, name: "id", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "index", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 3, name: "response", kind: "scalar", T: 12 /*ScalarType.BYTES*/ }
        ]);
    }
    create(value?: PartialMessage<ClientInquiryMsg>): ClientInquiryMsg {
        const message = { id: 0, index: 0, response: new Uint8Array(0) };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<ClientInquiryMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: ClientInquiryMsg): ClientInquiryMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 id */ 1:
                    message.id = reader.int32();
                    break;
                case /* int32 index */ 2:
                    message.index = reader.int32();
                    break;
                case /* bytes response */ 3:
                    message.response = reader.bytes();
                    break;
                default:
                    let u = options.readUnknownField;
                    if (u === "throw")
                        throw new globalThis.Error(`Unknown field ${fieldNo} (wire type ${wireType}) for ${this.typeName}`);
                    let d = reader.skip(wireType);
                    if (u !== false)
                        (u === true ? UnknownFieldHandler.onRead : u)(this.typeName, message, fieldNo, wireType, d);
            }
        }
        return message;
    }
    internalBinaryWrite(message: ClientInquiryMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 id = 1; */
        if (message.id !== 0)
            writer.tag(1, WireType.Varint).int32(message.id);
        /* int32 index = 2; */
        if (message.index !== 0)
            writer.tag(2, WireType.Varint).int32(message.index);
        /* bytes response = 3; */
        if (message.response.length)
            writer.tag(3, WireType.LengthDelimited).bytes(message.response);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message ClientInquiryMsg
 */
export const ClientInquiryMsg = new ClientInquiryMsg$Type();
