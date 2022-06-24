// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Events/InGame/DrawTileEvent.proto" (syntax proto3)
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
import { GameTileMsg } from "../../Core/GameTile";
import { TileSource } from "../../Core/GameTile";
/**
 * @generated from protobuf message DrawTileEventMsg
 */
export interface DrawTileEventMsg {
    /**
     * @generated from protobuf field: int32 player_id = 1;
     */
    playerId: number;
    /**
     * @generated from protobuf field: TileSource source = 2;
     */
    source: TileSource;
    /**
     * @generated from protobuf field: GameTileMsg tile = 3;
     */
    tile?: GameTileMsg;
}
// @generated message type with reflection information, may provide speed optimized methods
class DrawTileEventMsg$Type extends MessageType<DrawTileEventMsg> {
    constructor() {
        super("DrawTileEventMsg", [
            { no: 1, name: "player_id", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "source", kind: "enum", T: () => ["TileSource", TileSource, "TILE_SOURCE_"] },
            { no: 3, name: "tile", kind: "message", T: () => GameTileMsg }
        ]);
    }
    create(value?: PartialMessage<DrawTileEventMsg>): DrawTileEventMsg {
        const message = { playerId: 0, source: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<DrawTileEventMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: DrawTileEventMsg): DrawTileEventMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 player_id */ 1:
                    message.playerId = reader.int32();
                    break;
                case /* TileSource source */ 2:
                    message.source = reader.int32();
                    break;
                case /* GameTileMsg tile */ 3:
                    message.tile = GameTileMsg.internalBinaryRead(reader, reader.uint32(), options, message.tile);
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
    internalBinaryWrite(message: DrawTileEventMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 player_id = 1; */
        if (message.playerId !== 0)
            writer.tag(1, WireType.Varint).int32(message.playerId);
        /* TileSource source = 2; */
        if (message.source !== 0)
            writer.tag(2, WireType.Varint).int32(message.source);
        /* GameTileMsg tile = 3; */
        if (message.tile)
            GameTileMsg.internalBinaryWrite(message.tile, writer.tag(3, WireType.LengthDelimited).fork(), options).join();
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message DrawTileEventMsg
 */
export const DrawTileEventMsg = new DrawTileEventMsg$Type();
