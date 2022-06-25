// @generated by protobuf-ts 2.7.0
// @generated from protobuf file "Actions/SinglePlayerInquiry.proto" (syntax proto3)
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
import { SkipActionMsg } from "./SkipAction";
import { RyuukyokuActionMsg } from "./RyuukyokuAction";
import { PonActionMsg } from "./PonAction";
import { RiichiActionMsg } from "./PlayTileAction";
import { PlayTileActionMsg } from "./PlayTileAction";
import { KanActionMsg } from "./KanAction";
import { ChiiActionMsg } from "./ChiiAction";
import { AgariActionMsg } from "./AgariAction";
/**
 * @generated from protobuf message PlayerActionMsg
 */
export interface PlayerActionMsg {
    /**
     * @generated from protobuf oneof: action
     */
    action: {
        oneofKind: "agariAction";
        /**
         * @generated from protobuf field: AgariActionMsg agari_action = 1;
         */
        agariAction: AgariActionMsg;
    } | {
        oneofKind: "chiiAction";
        /**
         * @generated from protobuf field: ChiiActionMsg chii_action = 2;
         */
        chiiAction: ChiiActionMsg;
    } | {
        oneofKind: "kanAction";
        /**
         * @generated from protobuf field: KanActionMsg kan_action = 3;
         */
        kanAction: KanActionMsg;
    } | {
        oneofKind: "playTileAction";
        /**
         * @generated from protobuf field: PlayTileActionMsg play_tile_action = 4;
         */
        playTileAction: PlayTileActionMsg;
    } | {
        oneofKind: "riichiAction";
        /**
         * @generated from protobuf field: RiichiActionMsg riichi_action = 5;
         */
        riichiAction: RiichiActionMsg;
    } | {
        oneofKind: "ponAction";
        /**
         * @generated from protobuf field: PonActionMsg pon_action = 6;
         */
        ponAction: PonActionMsg;
    } | {
        oneofKind: "ryuukyokuAction";
        /**
         * @generated from protobuf field: RyuukyokuActionMsg ryuukyoku_action = 7;
         */
        ryuukyokuAction: RyuukyokuActionMsg;
    } | {
        oneofKind: "skipAction";
        /**
         * @generated from protobuf field: SkipActionMsg skip_action = 8;
         */
        skipAction: SkipActionMsg;
    } | {
        oneofKind: undefined;
    };
}
/**
 * @generated from protobuf message SinglePlayerInquiryMsg
 */
export interface SinglePlayerInquiryMsg {
    /**
     * @generated from protobuf field: repeated PlayerActionMsg actions = 1;
     */
    actions: PlayerActionMsg[];
}
// @generated message type with reflection information, may provide speed optimized methods
class PlayerActionMsg$Type extends MessageType<PlayerActionMsg> {
    constructor() {
        super("PlayerActionMsg", [
            { no: 1, name: "agari_action", kind: "message", oneof: "action", T: () => AgariActionMsg },
            { no: 2, name: "chii_action", kind: "message", oneof: "action", T: () => ChiiActionMsg },
            { no: 3, name: "kan_action", kind: "message", oneof: "action", T: () => KanActionMsg },
            { no: 4, name: "play_tile_action", kind: "message", oneof: "action", T: () => PlayTileActionMsg },
            { no: 5, name: "riichi_action", kind: "message", oneof: "action", T: () => RiichiActionMsg },
            { no: 6, name: "pon_action", kind: "message", oneof: "action", T: () => PonActionMsg },
            { no: 7, name: "ryuukyoku_action", kind: "message", oneof: "action", T: () => RyuukyokuActionMsg },
            { no: 8, name: "skip_action", kind: "message", oneof: "action", T: () => SkipActionMsg }
        ]);
    }
    create(value?: PartialMessage<PlayerActionMsg>): PlayerActionMsg {
        const message = { action: { oneofKind: undefined } };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<PlayerActionMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: PlayerActionMsg): PlayerActionMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* AgariActionMsg agari_action */ 1:
                    message.action = {
                        oneofKind: "agariAction",
                        agariAction: AgariActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).agariAction)
                    };
                    break;
                case /* ChiiActionMsg chii_action */ 2:
                    message.action = {
                        oneofKind: "chiiAction",
                        chiiAction: ChiiActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).chiiAction)
                    };
                    break;
                case /* KanActionMsg kan_action */ 3:
                    message.action = {
                        oneofKind: "kanAction",
                        kanAction: KanActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).kanAction)
                    };
                    break;
                case /* PlayTileActionMsg play_tile_action */ 4:
                    message.action = {
                        oneofKind: "playTileAction",
                        playTileAction: PlayTileActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).playTileAction)
                    };
                    break;
                case /* RiichiActionMsg riichi_action */ 5:
                    message.action = {
                        oneofKind: "riichiAction",
                        riichiAction: RiichiActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).riichiAction)
                    };
                    break;
                case /* PonActionMsg pon_action */ 6:
                    message.action = {
                        oneofKind: "ponAction",
                        ponAction: PonActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).ponAction)
                    };
                    break;
                case /* RyuukyokuActionMsg ryuukyoku_action */ 7:
                    message.action = {
                        oneofKind: "ryuukyokuAction",
                        ryuukyokuAction: RyuukyokuActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).ryuukyokuAction)
                    };
                    break;
                case /* SkipActionMsg skip_action */ 8:
                    message.action = {
                        oneofKind: "skipAction",
                        skipAction: SkipActionMsg.internalBinaryRead(reader, reader.uint32(), options, (message.action as any).skipAction)
                    };
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
    internalBinaryWrite(message: PlayerActionMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* AgariActionMsg agari_action = 1; */
        if (message.action.oneofKind === "agariAction")
            AgariActionMsg.internalBinaryWrite(message.action.agariAction, writer.tag(1, WireType.LengthDelimited).fork(), options).join();
        /* ChiiActionMsg chii_action = 2; */
        if (message.action.oneofKind === "chiiAction")
            ChiiActionMsg.internalBinaryWrite(message.action.chiiAction, writer.tag(2, WireType.LengthDelimited).fork(), options).join();
        /* KanActionMsg kan_action = 3; */
        if (message.action.oneofKind === "kanAction")
            KanActionMsg.internalBinaryWrite(message.action.kanAction, writer.tag(3, WireType.LengthDelimited).fork(), options).join();
        /* PlayTileActionMsg play_tile_action = 4; */
        if (message.action.oneofKind === "playTileAction")
            PlayTileActionMsg.internalBinaryWrite(message.action.playTileAction, writer.tag(4, WireType.LengthDelimited).fork(), options).join();
        /* RiichiActionMsg riichi_action = 5; */
        if (message.action.oneofKind === "riichiAction")
            RiichiActionMsg.internalBinaryWrite(message.action.riichiAction, writer.tag(5, WireType.LengthDelimited).fork(), options).join();
        /* PonActionMsg pon_action = 6; */
        if (message.action.oneofKind === "ponAction")
            PonActionMsg.internalBinaryWrite(message.action.ponAction, writer.tag(6, WireType.LengthDelimited).fork(), options).join();
        /* RyuukyokuActionMsg ryuukyoku_action = 7; */
        if (message.action.oneofKind === "ryuukyokuAction")
            RyuukyokuActionMsg.internalBinaryWrite(message.action.ryuukyokuAction, writer.tag(7, WireType.LengthDelimited).fork(), options).join();
        /* SkipActionMsg skip_action = 8; */
        if (message.action.oneofKind === "skipAction")
            SkipActionMsg.internalBinaryWrite(message.action.skipAction, writer.tag(8, WireType.LengthDelimited).fork(), options).join();
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message PlayerActionMsg
 */
export const PlayerActionMsg = new PlayerActionMsg$Type();
// @generated message type with reflection information, may provide speed optimized methods
class SinglePlayerInquiryMsg$Type extends MessageType<SinglePlayerInquiryMsg> {
    constructor() {
        super("SinglePlayerInquiryMsg", [
            { no: 1, name: "actions", kind: "message", repeat: 1 /*RepeatType.PACKED*/, T: () => PlayerActionMsg }
        ]);
    }
    create(value?: PartialMessage<SinglePlayerInquiryMsg>): SinglePlayerInquiryMsg {
        const message = { actions: [] };
        globalThis.Object.defineProperty(message, MESSAGE_TYPE, { enumerable: false, value: this });
        if (value !== undefined)
            reflectionMergePartial<SinglePlayerInquiryMsg>(this, message, value);
        return message;
    }
    internalBinaryRead(reader: IBinaryReader, length: number, options: BinaryReadOptions, target?: SinglePlayerInquiryMsg): SinglePlayerInquiryMsg {
        let message = target ?? this.create(), end = reader.pos + length;
        while (reader.pos < end) {
            let [fieldNo, wireType] = reader.tag();
            switch (fieldNo) {
                case /* repeated PlayerActionMsg actions */ 1:
                    message.actions.push(PlayerActionMsg.internalBinaryRead(reader, reader.uint32(), options));
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
    internalBinaryWrite(message: SinglePlayerInquiryMsg, writer: IBinaryWriter, options: BinaryWriteOptions): IBinaryWriter {
        /* repeated PlayerActionMsg actions = 1; */
        for (let i = 0; i < message.actions.length; i++)
            PlayerActionMsg.internalBinaryWrite(message.actions[i], writer.tag(1, WireType.LengthDelimited).fork(), options).join();
        let u = options.writeUnknownFields;
        if (u !== false)
            (u == true ? UnknownFieldHandler.onWrite : u)(this.typeName, message, writer);
        return writer;
    }
}
/**
 * @generated MessageType for protobuf message SinglePlayerInquiryMsg
 */
export const SinglePlayerInquiryMsg = new SinglePlayerInquiryMsg$Type();
