/* eslint-disable */
import * as Long from "long";
import * as _m0 from "protobufjs/minimal";
import { GameTileMsg } from "./GameTile";

export const protobufPackage = "";

export interface MenLikeMsg {
  tiles: GameTileMsg[];
}

function createBaseMenLikeMsg(): MenLikeMsg {
  return { tiles: [] };
}

export const MenLikeMsg = {
  encode(
    message: MenLikeMsg,
    writer: _m0.Writer = _m0.Writer.create()
  ): _m0.Writer {
    for (const v of message.tiles) {
      GameTileMsg.encode(v!, writer.uint32(10).fork()).ldelim();
    }
    return writer;
  },

  decode(input: _m0.Reader | Uint8Array, length?: number): MenLikeMsg {
    const reader = input instanceof _m0.Reader ? input : new _m0.Reader(input);
    let end = length === undefined ? reader.len : reader.pos + length;
    const message = createBaseMenLikeMsg();
    while (reader.pos < end) {
      const tag = reader.uint32();
      switch (tag >>> 3) {
        case 1:
          message.tiles.push(GameTileMsg.decode(reader, reader.uint32()));
          break;
        default:
          reader.skipType(tag & 7);
          break;
      }
    }
    return message;
  },

  fromJSON(object: any): MenLikeMsg {
    return {
      tiles: Array.isArray(object?.tiles)
        ? object.tiles.map((e: any) => GameTileMsg.fromJSON(e))
        : [],
    };
  },

  toJSON(message: MenLikeMsg): unknown {
    const obj: any = {};
    if (message.tiles) {
      obj.tiles = message.tiles.map((e) =>
        e ? GameTileMsg.toJSON(e) : undefined
      );
    } else {
      obj.tiles = [];
    }
    return obj;
  },

  fromPartial<I extends Exact<DeepPartial<MenLikeMsg>, I>>(
    object: I
  ): MenLikeMsg {
    const message = createBaseMenLikeMsg();
    message.tiles = object.tiles?.map((e) => GameTileMsg.fromPartial(e)) || [];
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
