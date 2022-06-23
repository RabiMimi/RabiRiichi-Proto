// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Patterns/ScoreCalcResult.proto" (syntax proto3)
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
 * @generated from protobuf message ScoreCalcResultMsg
 */
export interface ScoreCalcResultMsg {
    /**
     * @generated from protobuf field: int32 han = 1;
     */
    han: number;
    /**
     * @generated from protobuf field: int32 yaku = 2;
     */
    yaku: number;
    /**
     * @generated from protobuf field: int32 fu = 3;
     */
    fu: number;
    /**
     * @generated from protobuf field: int32 yakuman = 4;
     */
    yakuman: number;
    /**
     * @generated from protobuf field: int32 KazoeYakuman = 5 [json_name = "KazoeYakuman"];
     */
    kazoeYakuman: number;
    /**
     * @generated from protobuf field: int32 FinalYakuman = 6 [json_name = "FinalYakuman"];
     */
    finalYakuman: number;
}
// @generated message type with reflection information, may provide speed optimized methods
class ScoreCalcResultMsg$Type extends MessageType<ScoreCalcResultMsg> {
    constructor() {
        super("ScoreCalcResultMsg", [
            { no: 1, name: "han", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "yaku", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 3, name: "fu", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 4, name: "yakuman", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 5, name: "KazoeYakuman", kind: "scalar", jsonName: "KazoeYakuman", T: 5 /*ScalarType.INT32*/ },
            { no: 6, name: "FinalYakuman", kind: "scalar", jsonName: "FinalYakuman", T: 5 /*ScalarType.INT32*/ }
        ]);
    }
    create(value?: PartialMessage<ScoreCalcResultMsg>): ScoreCalcResultMsg {
        const message = { han: 0, yaku: 0, fu: 0, yakuman: 0, kazoeYakuman: 0, finalYakuman: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<ScoreCalcResultMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: ScoreCalcResultMsg): ScoreCalcResultMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 han */ 1:
                    message.han = reader.int32();
                    break;
                case /* int32 yaku */ 2:
                    message.yaku = reader.int32();
                    break;
                case /* int32 fu */ 3:
                    message.fu = reader.int32();
                    break;
                case /* int32 yakuman */ 4:
                    message.yakuman = reader.int32();
                    break;
                case /* int32 KazoeYakuman = 5 [json_name = "KazoeYakuman"];*/ 5:
                    message.kazoeYakuman = reader.int32();
                    break;
                case /* int32 FinalYakuman = 6 [json_name = "FinalYakuman"];*/ 6:
                    message.finalYakuman = reader.int32();
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
    internalBinaryWrite(message: ScoreCalcResultMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 han = 1; */
        if (message.han !== 0)
            writer.tag(1, WireType.Varint).int32(message.han);
        /* int32 yaku = 2; */
        if (message.yaku !== 0)
            writer.tag(2, WireType.Varint).int32(message.yaku);
        /* int32 fu = 3; */
        if (message.fu !== 0)
            writer.tag(3, WireType.Varint).int32(message.fu);
        /* int32 yakuman = 4; */
        if (message.yakuman !== 0)
            writer.tag(4, WireType.Varint).int32(message.yakuman);
        /* int32 KazoeYakuman = 5 [json_name = "KazoeYakuman"]; */
        if (message.kazoeYakuman !== 0)
            writer.tag(5, WireType.Varint).int32(message.kazoeYakuman);
        /* int32 FinalYakuman = 6 [json_name = "FinalYakuman"]; */
        if (message.finalYakuman !== 0)
            writer.tag(6, WireType.Varint).int32(message.finalYakuman);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message ScoreCalcResultMsg
 */
export const ScoreCalcResultMsg = new ScoreCalcResultMsg$Type();
