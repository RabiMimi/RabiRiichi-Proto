// @generated by protobuf-ts 2.7.0 with parameter client_grpc1
// @generated from protobuf file "Events/InGame/BeginGameEvent.proto" (syntax proto3)
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
/**
 * @generated from protobuf message BeginGameEventMsg
 */
export interface BeginGameEventMsg {
    /**
     * @generated from protobuf field: int32 round = 1;
     */
    round: number;
    /**
     * @generated from protobuf field: int32 dealer = 2;
     */
    dealer: number;
    /**
     * @generated from protobuf field: int32 honba = 3;
     */
    honba: number;
}
// @generated message type with reflection information, may provide speed optimized methods
class BeginGameEventMsg$Type extends MessageType<BeginGameEventMsg> {
    constructor() {
        super("BeginGameEventMsg", [
            { no: 1, name: "round", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "dealer", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 3, name: "honba", kind: "scalar", T: 5 /*ScalarType.INT32*/ }
        ]);
    }
    create(value?: PartialMessage<BeginGameEventMsg>): BeginGameEventMsg {
        const message = { round: 0, dealer: 0, honba: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<BeginGameEventMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: BeginGameEventMsg): BeginGameEventMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 round */ 1:
                    message.round = reader.int32();
                    break;
                case /* int32 dealer */ 2:
                    message.dealer = reader.int32();
                    break;
                case /* int32 honba */ 3:
                    message.honba = reader.int32();
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
    internalBinaryWrite(message: BeginGameEventMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 round = 1; */
        if (message.round !== 0)
            writer.tag(1, WireType.Varint).int32(message.round);
        /* int32 dealer = 2; */
        if (message.dealer !== 0)
            writer.tag(2, WireType.Varint).int32(message.dealer);
        /* int32 honba = 3; */
        if (message.honba !== 0)
            writer.tag(3, WireType.Varint).int32(message.honba);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message BeginGameEventMsg
 */
export const BeginGameEventMsg = new BeginGameEventMsg$Type();
