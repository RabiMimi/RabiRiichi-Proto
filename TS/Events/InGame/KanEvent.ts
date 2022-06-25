// @generated by protobuf-ts 2.7.0 with parameter client_grpc1
// @generated from protobuf file "Events/InGame/KanEvent.proto" (syntax proto3)
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
import { TileSource } from "../../Core/GameTile";
import { MenLikeMsg } from "../../Core/MenLike";
/**
 * @generated from protobuf message KanEventMsg
 */
export interface KanEventMsg {
    /**
     * @generated from protobuf field: int32 player_id = 1;
     */
    playerId: number;
    /**
     * @generated from protobuf field: MenLikeMsg kan = 2;
     */
    kan?: MenLikeMsg;
    /**
     * @generated from protobuf field: TileSource kan_source = 3;
     */
    kanSource: TileSource;
}
// @generated message type with reflection information, may provide speed optimized methods
class KanEventMsg$Type extends MessageType<KanEventMsg> {
    constructor() {
        super("KanEventMsg", [
            { no: 1, name: "player_id", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "kan", kind: "message", T: () => MenLikeMsg },
            { no: 3, name: "kan_source", kind: "enum", T: () => ["TileSource", TileSource, "TILE_SOURCE_"] }
        ]);
    }
    create(value?: PartialMessage<KanEventMsg>): KanEventMsg {
        const message = { playerId: 0, kanSource: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<KanEventMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: KanEventMsg): KanEventMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 player_id */ 1:
                    message.playerId = reader.int32();
                    break;
                case /* MenLikeMsg kan */ 2:
                    message.kan = MenLikeMsg.internalBinaryRead(reader, reader.uint32(), options, message.kan);
                    break;
                case /* TileSource kan_source */ 3:
                    message.kanSource = reader.int32();
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
    internalBinaryWrite(message: KanEventMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 player_id = 1; */
        if (message.playerId !== 0)
            writer.tag(1, WireType.Varint).int32(message.playerId);
        /* MenLikeMsg kan = 2; */
        if (message.kan)
            MenLikeMsg.internalBinaryWrite(message.kan, writer.tag(2, WireType.LengthDelimited).fork(), options).join();
        /* TileSource kan_source = 3; */
        if (message.kanSource !== 0)
            writer.tag(3, WireType.Varint).int32(message.kanSource);
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message KanEventMsg
 */
export const KanEventMsg = new KanEventMsg$Type();
