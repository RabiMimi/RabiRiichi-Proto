/* eslint-disable */
import * as Long from "long";
import * as _m0 from "protobufjs/minimal";
import { MenLikeMsg } from "../../Core/MenLike";
import { GameTileMsg } from "../../Core/GameTile";

export const protobufPackage = "";

export interface PlayerHandStateMsg {
  called: MenLikeMsg[];
  discarded: GameTileMsg[];
  jun: number;
  riichiStick: number;
  agariTile: GameTileMsg | undefined;
  riichi: boolean;
}

function createBasePlayerHandStateMsg(): PlayerHandStateMsg {
  return {
    called: [],
    discarded: [],
    jun: 0,
    riichiStick: 0,
    agariTile: undefined,
    riichi: false,
  };
}

export const PlayerHandStateMsg = {
  encode(
    message: PlayerHandStateMsg,
    writer: _m0.Writer = _m0.Writer.create()
  ): _m0.Writer {
    for (const v of message.called) {
      MenLikeMsg.encode(v!, writer.uint32(10).fork()).ldelim();
    }
    for (const v of message.discarded) {
      GameTileMsg.encode(v!, writer.uint32(18).fork()).ldelim();
    }
    if (message.jun !== 0) {
      writer.uint32(24).int32(message.jun);
    }
    if (message.riichiStick !== 0) {
      writer.uint32(32).int32(message.riichiStick);
    }
    if (message.agariTile !== undefined) {
      GameTileMsg.encode(message.agariTile, writer.uint32(42).fork()).ldelim();
    }
    if (message.riichi === true) {
      writer.uint32(48).bool(message.riichi);
    }
    return writer;
  },

  decode(input: _m0.Reader | Uint8Array, length?: number): PlayerHandStateMsg {
    const reader = input instanceof _m0.Reader ? input : new _m0.Reader(input);
    let end = length === undefined ? reader.len : reader.pos + length;
    const message = createBasePlayerHandStateMsg();
    while (reader.pos < end) {
      const tag = reader.uint32();
      switch (tag >>> 3) {
        case 1:
          message.called.push(MenLikeMsg.decode(reader, reader.uint32()));
          break;
        case 2:
          message.discarded.push(GameTileMsg.decode(reader, reader.uint32()));
          break;
        case 3:
          message.jun = reader.int32();
          break;
        case 4:
          message.riichiStick = reader.int32();
          break;
        case 5:
          message.agariTile = GameTileMsg.decode(reader, reader.uint32());
          break;
        case 6:
          message.riichi = reader.bool();
          break;
        default:
          reader.skipType(tag & 7);
          break;
      }
    }
    return message;
  },

  fromJSON(object: any): PlayerHandStateMsg {
    return {
      called: Array.isArray(object?.called)
        ? object.called.map((e: any) => MenLikeMsg.fromJSON(e))
        : [],
      discarded: Array.isArray(object?.discarded)
        ? object.discarded.map((e: any) => GameTileMsg.fromJSON(e))
        : [],
      jun: isSet(object.jun) ? Number(object.jun) : 0,
      riichiStick: isSet(object.riichiStick) ? Number(object.riichiStick) : 0,
      agariTile: isSet(object.agariTile)
        ? GameTileMsg.fromJSON(object.agariTile)
        : undefined,
      riichi: isSet(object.riichi) ? Boolean(object.riichi) : false,
    };
  },

  toJSON(message: PlayerHandStateMsg): unknown {
    const obj: any = {};
    if (message.called) {
      obj.called = message.called.map((e) =>
        e ? MenLikeMsg.toJSON(e) : undefined
      );
    } else {
      obj.called = [];
    }
    if (message.discarded) {
      obj.discarded = message.discarded.map((e) =>
        e ? GameTileMsg.toJSON(e) : undefined
      );
    } else {
      obj.discarded = [];
    }
    message.jun !== undefined && (obj.jun = Math.round(message.jun));
    message.riichiStick !== undefined &&
      (obj.riichiStick = Math.round(message.riichiStick));
    message.agariTile !== undefined &&
      (obj.agariTile = message.agariTile
        ? GameTileMsg.toJSON(message.agariTile)
        : undefined);
    message.riichi !== undefined && (obj.riichi = message.riichi);
    return obj;
  },

  fromPartial<I extends Exact<DeepPartial<PlayerHandStateMsg>, I>>(
    object: I
  ): PlayerHandStateMsg {
    const message = createBasePlayerHandStateMsg();
    message.called = object.called?.map((e) => MenLikeMsg.fromPartial(e)) || [];
    message.discarded =
      object.discarded?.map((e) => GameTileMsg.fromPartial(e)) || [];
    message.jun = object.jun ?? 0;
    message.riichiStick = object.riichiStick ?? 0;
    message.agariTile =
      object.agariTile !== undefined && object.agariTile !== null
        ? GameTileMsg.fromPartial(object.agariTile)
        : undefined;
    message.riichi = object.riichi ?? false;
    return message;
  },
};

type Builtin =
  | Date
  | Function
  | Uint8Array
  | string
  | number
  | boolean
  | undefined;

export type DeepPartial<T> = T extends Builtin
  ? T
  : T extends Array<infer U>
  ? Array<DeepPartial<U>>
  : T extends ReadonlyArray<infer U>
  ? ReadonlyArray<DeepPartial<U>>
  : T extends {}
  ? { [K in keyof T]?: DeepPartial<T[K]> }
  : Partial<T>;

type KeysOfUnion<T> = T extends T ? keyof T : never;
export type Exact<P, I extends P> = P extends Builtin
  ? P
  : P & { [K in keyof P]: Exact<P[K], I[K]> } & Record<
        Exclude<keyof I, KeysOfUnion<P>>,
        never
      >;

// If you get a compile-error about 'Constructor<Long> and ... have no overlap',
// add '--ts_proto_opt=esModuleInterop=true' as a flag when calling 'protoc'.
if (_m0.util.Long !== Long) {
  _m0.util.Long = Long as any;
  _m0.configure();
}

function isSet(value: any): boolean {
  return value !== null && value !== undefined;
}
