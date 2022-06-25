// @generated by protobuf-ts 2.7.0 with parameter client_grpc1
// @generated from protobuf file "Events/InGame/RevealDoraEvent.proto" (syntax proto3)
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
/**
 * @generated from protobuf message RevealDoraEventMsg
 */
export interface RevealDoraEventMsg {
    /**
     * @generated from protobuf field: int32 player_id = 1;
     */
    playerId: number;
    /**
     * @generated from protobuf field: GameTileMsg dora = 2;
     */
    dora?: GameTileMsg;
}
// @generated message type with reflection information, may provide speed optimized methods
class RevealDoraEventMsg$Type extends MessageType<RevealDoraEventMsg> {
    constructor() {
        super("RevealDoraEventMsg", [
            { no: 1, name: "player_id", kind: "scalar", T: 5 /*ScalarType.INT32*/ },
            { no: 2, name: "dora", kind: "message", T: () => GameTileMsg }
        ]);
    }
    create(value?: PartialMessage<RevealDoraEventMsg>): RevealDoraEventMsg {
        const message = { playerId: 0 };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<RevealDoraEventMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: RevealDoraEventMsg): RevealDoraEventMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* int32 player_id */ 1:
                    message.playerId = reader.int32();
                    break;
                case /* GameTileMsg dora */ 2:
                    message.dora = GameTileMsg.internalBinaryRead(reader, reader.uint32(), options, message.dora);
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
    internalBinaryWrite(message: RevealDoraEventMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* int32 player_id = 1; */
        if (message.playerId !== 0)
            writer.tag(1, WireType.Varint).int32(message.playerId);
        /* GameTileMsg dora = 2; */
        if (message.dora)
            GameTileMsg.internalBinaryWrite(message.dora, writer.tag(2, WireType.LengthDelimited).fork(), options).join();
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message RevealDoraEventMsg
 */
export const RevealDoraEventMsg = new RevealDoraEventMsg$Type();
