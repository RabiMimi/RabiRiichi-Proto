/* eslint-disable */
import * as Long from "long";
import * as _m0 from "protobufjs/minimal";

export const protobufPackage = "";

export enum DiscardReason {
  DiscardReason_None = 0,
  DiscardReason_Draw = 1,
  DiscardReason_DrawRinshan = 2,
  DiscardReason_Chii = 3,
  DiscardReason_Pon = 4,
  DiscardReason_ChanKan = 5,
  DiscardReason_Pretend = 6,
  UNRECOGNIZED = -1,
}

export function discardReasonFromJSON(object: any): DiscardReason {
  switch (object) {
    case 0:
    case "DiscardReason_None":
      return DiscardReason.DiscardReason_None;
    case 1:
    case "DiscardReason_Draw":
      return DiscardReason.DiscardReason_Draw;
    case 2:
    case "DiscardReason_DrawRinshan":
      return DiscardReason.DiscardReason_DrawRinshan;
    case 3:
    case "DiscardReason_Chii":
      return DiscardReason.DiscardReason_Chii;
    case 4:
    case "DiscardReason_Pon":
      return DiscardReason.DiscardReason_Pon;
    case 5:
    case "DiscardReason_ChanKan":
      return DiscardReason.DiscardReason_ChanKan;
    case 6:
    case "DiscardReason_Pretend":
      return DiscardReason.DiscardReason_Pretend;
    case -1:
    case "UNRECOGNIZED":
    default:
      return DiscardReason.UNRECOGNIZED;
  }
}

export function discardReasonToJSON(object: DiscardReason): string {
  switch (object) {
    case DiscardReason.DiscardReason_None:
      return "DiscardReason_None";
    case DiscardReason.DiscardReason_Draw:
      return "DiscardReason_Draw";
    case DiscardReason.DiscardReason_DrawRinshan:
      return "DiscardReason_DrawRinshan";
    case DiscardReason.DiscardReason_Chii:
      return "DiscardReason_Chii";
    case DiscardReason.DiscardReason_Pon:
      return "DiscardReason_Pon";
    case DiscardReason.DiscardReason_ChanKan:
      return "DiscardReason_ChanKan";
    case DiscardReason.DiscardReason_Pretend:
      return "DiscardReason_Pretend";
    case DiscardReason.UNRECOGNIZED:
    default:
      return "UNRECOGNIZED";
  }
}

export enum TileSource {
  TileSource_None = 0,
  TileSource_Wanpai = 1,
  TileSource_Wall = 2,
  TileSource_Hand = 3,
  TileSource_Discard = 4,
  TileSource_Chii = 5,
  TileSource_Pon = 6,
  TileSource_KaKan = 7,
  TileSource_AnKan = 8,
  TileSource_DaiMinKan = 9,
  UNRECOGNIZED = -1,
}

export function tileSourceFromJSON(object: any): TileSource {
  switch (object) {
    case 0:
    case "TileSource_None":
      return TileSource.TileSource_None;
    case 1:
    case "TileSource_Wanpai":
      return TileSource.TileSource_Wanpai;
    case 2:
    case "TileSource_Wall":
      return TileSource.TileSource_Wall;
    case 3:
    case "TileSource_Hand":
      return TileSource.TileSource_Hand;
    case 4:
    case "TileSource_Discard":
      return TileSource.TileSource_Discard;
    case 5:
    case "TileSource_Chii":
      return TileSource.TileSource_Chii;
    case 6:
    case "TileSource_Pon":
      return TileSource.TileSource_Pon;
    case 7:
    case "TileSource_KaKan":
      return TileSource.TileSource_KaKan;
    case 8:
    case "TileSource_AnKan":
      return TileSource.TileSource_AnKan;
    case 9:
    case "TileSource_DaiMinKan":
      return TileSource.TileSource_DaiMinKan;
    case -1:
    case "UNRECOGNIZED":
    default:
      return TileSource.UNRECOGNIZED;
  }
}

export function tileSourceToJSON(object: TileSource): string {
  switch (object) {
    case TileSource.TileSource_None:
      return "TileSource_None";
    case TileSource.TileSource_Wanpai:
      return "TileSource_Wanpai";
    case TileSource.TileSource_Wall:
      return "TileSource_Wall";
    case TileSource.TileSource_Hand:
      return "TileSource_Hand";
    case TileSource.TileSource_Discard:
      return "TileSource_Discard";
    case TileSource.TileSource_Chii:
      return "TileSource_Chii";
    case TileSource.TileSource_Pon:
      return "TileSource_Pon";
    case TileSource.TileSource_KaKan:
      return "TileSource_KaKan";
    case TileSource.TileSource_AnKan:
      return "TileSource_AnKan";
    case TileSource.TileSource_DaiMinKan:
      return "TileSource_DaiMinKan";
    case TileSource.UNRECOGNIZED:
    default:
      return "UNRECOGNIZED";
  }
}

export interface DiscardInfoMsg {
  from: number;
  reason: DiscardReason;
}

export interface GameTileMsg {
  tile: string;
  playerId: number;
  discardInfo: DiscardInfoMsg | undefined;
  source: TileSource;
}

function createBaseDiscardInfoMsg(): DiscardInfoMsg {
  return { from: 0, reason: 0 };
}

export const DiscardInfoMsg = {
  encode(
    message: DiscardInfoMsg,
    writer: _m0.Writer = _m0.Writer.create()
  ): _m0.Writer {
    if (message.from !== 0) {
      writer.uint32(8).int32(message.from);
    }
    if (message.reason !== 0) {
      writer.uint32(16).int32(message.reason);
    }
    return writer;
  },

  decode(input: _m0.Reader | Uint8Array, length?: number): DiscardInfoMsg {
    const reader = input instanceof _m0.Reader ? input : new _m0.Reader(input);
    let end = length === undefined ? reader.len : reader.pos + length;
    const message = createBaseDiscardInfoMsg();
    while (reader.pos < end) {
      const tag = reader.uint32();
      switch (tag >>> 3) {
        case 1:
          message.from = reader.int32();
          break;
        case 2:
          message.reason = reader.int32() as any;
          break;
        default:
          reader.skipType(tag & 7);
          break;
      }
    }
    return message;
  },

  fromJSON(object: any): DiscardInfoMsg {
    return {
      from: isSet(object.from) ? Number(object.from) : 0,
      reason: isSet(object.reason) ? discardReasonFromJSON(object.reason) : 0,
    };
  },

  toJSON(message: DiscardInfoMsg): unknown {
    const obj: any = {};
    message.from !== undefined && (obj.from = Math.round(message.from));
    message.reason !== undefined &&
      (obj.reason = discardReasonToJSON(message.reason));
    return obj;
  },

  fromPartial<I extends Exact<DeepPartial<DiscardInfoMsg>, I>>(
    object: I
  ): DiscardInfoMsg {
    const message = createBaseDiscardInfoMsg();
    message.from = object.from ?? 0;
    message.reason = object.reason ?? 0;
    return message;
  },
};

function createBaseGameTileMsg(): GameTileMsg {
  return { tile: "", playerId: 0, discardInfo: undefined, source: 0 };
}

export const GameTileMsg = {
  encode(
    message: GameTileMsg,
    writer: _m0.Writer = _m0.Writer.create()
  ): _m0.Writer {
    if (message.tile !== "") {
      writer.uint32(10).string(message.tile);
    }
    if (message.playerId !== 0) {
      writer.uint32(16).int32(message.playerId);
    }
    if (message.discardInfo !== undefined) {
      DiscardInfoMsg.encode(
        message.discardInfo,
        writer.uint32(26).fork()
      ).ldelim();
    }
    if (message.source !== 0) {
      writer.uint32(32).int32(message.source);
    }
    return writer;
  },

  decode(input: _m0.Reader | Uint8Array, length?: number): GameTileMsg {
    const reader = input instanceof _m0.Reader ? input : new _m0.Reader(input);
    let end = length === undefined ? reader.len : reader.pos + length;
    const message = createBaseGameTileMsg();
    while (reader.pos < end) {
      const tag = reader.uint32();
      switch (tag >>> 3) {
        case 1:
          message.tile = reader.string();
          break;
        case 2:
          message.playerId = reader.int32();
          break;
        case 3:
          message.discardInfo = DiscardInfoMsg.decode(reader, reader.uint32());
          break;
        case 4:
          message.source = reader.int32() as any;
          break;
        default:
          reader.skipType(tag & 7);
          break;
      }
    }
    return message;
  },

  fromJSON(object: any): GameTileMsg {
    return {
      tile: isSet(object.tile) ? String(object.tile) : "",
      playerId: isSet(object.playerId) ? Number(object.playerId) : 0,
      discardInfo: isSet(object.discardInfo)
        ? DiscardInfoMsg.fromJSON(object.discardInfo)
        : undefined,
      source: isSet(object.source) ? tileSourceFromJSON(object.source) : 0,
    };
  },

  toJSON(message: GameTileMsg): unknown {
    const obj: any = {};
    message.tile !== undefined && (obj.tile = message.tile);
    message.playerId !== undefined &&
      (obj.playerId = Math.round(message.playerId));
    message.discardInfo !== undefined &&
      (obj.discardInfo = message.discardInfo
        ? DiscardInfoMsg.toJSON(message.discardInfo)
        : undefined);
    message.source !== undefined &&
      (obj.source = tileSourceToJSON(message.source));
    return obj;
  },

  fromPartial<I extends Exact<DeepPartial<GameTileMsg>, I>>(
    object: I
  ): GameTileMsg {
    const message = createBaseGameTileMsg();
    message.tile = object.tile ?? "";
    message.playerId = object.playerId ?? 0;
    message.discardInfo =
      object.discardInfo !== undefined && object.discardInfo !== null
        ? DiscardInfoMsg.fromPartial(object.discardInfo)
        : undefined;
    message.source = object.source ?? 0;
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
