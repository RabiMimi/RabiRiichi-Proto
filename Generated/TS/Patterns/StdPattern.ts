// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Patterns/StdPattern.proto" (syntax proto3)
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
 * @generated from protobuf message ScoringMsg
 */
export interface ScoringMsg {
    /**
     * @generated from protobuf field: ScoringType Type = 1 [json_name = "Type"];
     */
    type: ScoringType;
    /**
     * @generated from protobuf field: int32 Val = 2 [json_name = "Val"];
     */
    val: number;
    /**
     * @generated from protobuf field: string Src = 3 [json_name = "Src"];
     */
    src: string;
}
/**
 * @generated from protobuf enum ScoringType
 */
export enum ScoringType {
    /**
     * @generated from protobuf enum value: HAN = 0;
     */
    HAN = 0,
    /**
     * @generated from protobuf enum value: BONUS_HAN = 1;
     */
    BONUS_HAN = 1,
    /**
     * @generated from protobuf enum value: FU = 2;
     */
    FU = 2,
    /**
     * @generated from protobuf enum value: YAKUMAN = 3;
     */
    YAKUMAN = 3
}
// @generated message type with reflection information, may provide speed optimized methods
class ScoringMsg$Type extends MessageType<ScoringMsg> {
    constructor() {
        super("ScoringMsg", [
            { no: 1, name: "Type", kind: "enum", jsonName: "Type", T: () => ["ScoringType", ScoringType] },
            { no: 2, name: "Val", kind: "scalar", jsonName: "Val", T: 5 /*ScalarType.INT32*/ },
            { no: 3, name: "Src", kind: "scalar", jsonName: "Src", T: 9 /*ScalarType.STRING*/ }
        ]);
    }
    create(value?: PartialMessage<ScoringMsg>): ScoringMsg {
        const message = { type: 0, val: 0, src: "" };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<ScoringMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: ScoringMsg): ScoringMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* ScoringType Type = 1 [json_name = "Type"];*/ 1:
                    message.type = reader.int32();
                    break;
                case /* int32 Val = 2 [json_name = "Val"];*/ 2:
                    message.val = reader.int32();
                    break;
                case /* string Src = 3 [json_name = "Src"];*/ 3:
                    message.src = reader.string();
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
    internalBinaryWrite(message: ScoringMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* ScoringType Type = 1 [json_name = "Type"]; */
        if (message.type !== 0)
            writer.tag(1, WireType.Varint).int32(message.type);
        /* int32 Val = 2 [json_name = "Val"]; */
        if (message.val !== 0)
            writer.tag(2, WireType.Varint).int32(message.val);
        /* string Src = 3 [json_name = "Src"]; */
        if (message.src !== "")
            writer.tag(3, WireType.LengthDelimited).string(message.src);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message ScoringMsg
 */
export const ScoringMsg = new ScoringMsg$Type();
