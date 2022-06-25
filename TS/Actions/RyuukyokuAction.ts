// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Actions/RyuukyokuAction.proto" (syntax proto3)
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
 * @generated from protobuf message RyuukyokuActionMsg
 */
export interface RyuukyokuActionMsg {
    /**
     * @generated from protobuf field: string reason = 1;
     */
    reason: string;
}
// @generated message type with reflection information, may provide speed optimized methods
class RyuukyokuActionMsg$Type extends MessageType<RyuukyokuActionMsg> {
    constructor() {
        super("RyuukyokuActionMsg", [
            { no: 1, name: "reason", kind: "scalar", T: 9 /*ScalarType.STRING*/ }
        ]);
    }
    create(value?: PartialMessage<RyuukyokuActionMsg>): RyuukyokuActionMsg {
        const message = { reason: "" };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<RyuukyokuActionMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: RyuukyokuActionMsg): RyuukyokuActionMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* string reason */ 1:
                    message.reason = reader.string();
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
    internalBinaryWrite(message: RyuukyokuActionMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* string reason = 1; */
        if (message.reason !== "")
            writer.tag(1, WireType.LengthDelimited).string(message.reason);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message RyuukyokuActionMsg
 */
export const RyuukyokuActionMsg = new RyuukyokuActionMsg$Type();
