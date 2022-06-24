// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Events/InGame/StopGameEvent.proto" (syntax proto3)
// tslint:disable
import type { BinaryWriteOptions } from "@protobuf-ts/runtime";
import type { IBinaryWriter } from "@protobuf-ts/runtime";
import type { BinaryReadOptions } from "@protobuf-ts/runtime";
import type { IBinaryReader } from "@protobuf-ts/runtime";
import { UnknownFieldHandler } from "@protobuf-ts/runtime";
import { WireType } from "@protobuf-ts/runtime";
import type { PartialMessage } from "@protobuf-ts/runtime";
import { reflectionMergePartial } from "@protobuf-ts/runtime";
import { MESSAGE_TYPE } from "@protobuf-ts/runtime";
import { MessageType } from "@protobuf-ts/runtime";
/**
 * @generated from protobuf message StopGameEventMsg
 */
export interface StopGameEventMsg {
    /**
     * @generated from protobuf field: repeated int64 endGamePoints = 1;
     */
    endGamePoints: bigint[];
}
// @generated message type with reflection information, may provide speed optimized methods
class StopGameEventMsg$Type extends MessageType<StopGameEventMsg> {
    constructor() {
        super("StopGameEventMsg", [
            { no: 1, name: "endGamePoints", kind: "scalar", repeat: 1 /*RepeatType.PACKED*/, T: 3 /*ScalarType.INT64*/, L: 0 /*LongType.BIGINT*/ }
        ]);
    }
    create(value?: PartialMessage<StopGameEventMsg>): StopGameEventMsg {
        const message = { endGamePoints: [] };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<StopGameEventMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: StopGameEventMsg): StopGameEventMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* repeated int64 endGamePoints */ 1:
                    if (wireType === WireType.LengthDelimited)
                        for (let e = reader.int32() + reader.pos; reader.pos < e;)
                            message.endGamePoints.push(reader.int64().toBigInt());
                    else
                        message.endGamePoints.push(reader.int64().toBigInt());
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
    internalBinaryWrite(message: StopGameEventMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* repeated int64 endGamePoints = 1; */
        if (message.endGamePoints.length) {
            writer.tag(1, WireType.LengthDelimited).fork();
            for (let i = 0; i < message.endGamePoints.length; i++)
                writer.int64(message.endGamePoints[i]);
            writer.join();
        }
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message StopGameEventMsg
 */
export const StopGameEventMsg = new StopGameEventMsg$Type();
