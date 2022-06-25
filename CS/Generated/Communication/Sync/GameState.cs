// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Communication/Sync/GameState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Communication.Sync {

  /// <summary>Holder for reflection information generated from Communication/Sync/GameState.proto</summary>
  public static partial class GameStateReflection {

    #region Descriptor
    /// <summary>File descriptor for Communication/Sync/GameState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJDb21tdW5pY2F0aW9uL1N5bmMvR2FtZVN0YXRlLnByb3RvGhNDb3JlL0dh",
            "bWVUaWxlLnByb3RvGhJDb3JlL01lbkxpa2UucHJvdG8aEUNvcmUvUGxheWVy",
            "LnByb3RvGhNDb3JlL0dhbWVJbmZvLnByb3RvGhxDb3JlL0NvbmZpZy9HYW1l",
            "Q29uZmlnLnByb3RvIqwCChJQbGF5ZXJIYW5kU3RhdGVNc2cSIAoKZnJlZV90",
            "aWxlcxgBIAMoCzIMLkdhbWVUaWxlTXNnEhsKBmNhbGxlZBgCIAMoCzILLk1l",
            "bkxpa2VNc2cSHwoJZGlzY2FyZGVkGAMgAygLMgwuR2FtZVRpbGVNc2cSCwoD",
            "anVuGAQgASgFEhQKDHJpaWNoaV9zdGljaxgFIAEoBRIgCgphZ2FyaV90aWxl",
            "GAYgASgLMgwuR2FtZVRpbGVNc2cSIQoLcmlpY2hpX3RpbGUYByABKAsyDC5H",
            "YW1lVGlsZU1zZxIXCg9pc190ZW1wX2Z1cml0ZW4YCCABKAgSGQoRaXNfcmlp",
            "Y2hpX2Z1cml0ZW4YCSABKAgSGgoSaXNfZGlzY2FyZF9mdXJpdGVuGAogASgI",
            "IlkKDFdhbGxTdGF0ZU1zZxIbCgVkb3JhcxgBIAMoCzIMLkdhbWVUaWxlTXNn",
            "EhEKCXJlbWFpbmluZxgCIAEoBRIZChFyaW5zaGFuX3JlbWFpbmluZxgDIAEo",
            "BSJkCg5QbGF5ZXJTdGF0ZU1zZxIKCgJpZBgBIAEoBRITCgR3aW5kGAIgASgO",
            "MgUuV2luZBIOCgZwb2ludHMYAyABKAMSIQoEaGFuZBgEIAEoCzITLlBsYXll",
            "ckhhbmRTdGF0ZU1zZyKJAQoMR2FtZVN0YXRlTXNnEh4KBmNvbmZpZxgBIAEo",
            "CzIOLkdhbWVDb25maWdNc2cSGgoEaW5mbxgCIAEoCzIMLkdhbWVJbmZvTXNn",
            "EhsKBHdhbGwYAyABKAsyDS5XYWxsU3RhdGVNc2cSIAoHcGxheWVycxgEIAMo",
            "CzIPLlBsYXllclN0YXRlTXNnQiqqAidSYWJpUmlpY2hpLkdlbmVyYXRlZC5D",
            "b21tdW5pY2F0aW9uLlN5bmNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::RabiRiichi.Generated.Core.GameTileReflection.Descriptor, global::RabiRiichi.Generated.Core.MenLikeReflection.Descriptor, global::RabiRiichi.Generated.Core.PlayerReflection.Descriptor, global::RabiRiichi.Generated.Core.GameInfoReflection.Descriptor, global::RabiRiichi.Generated.Core.Config.GameConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Communication.Sync.PlayerHandStateMsg), global::RabiRiichi.Generated.Communication.Sync.PlayerHandStateMsg.Parser, new[]{ "FreeTiles", "Called", "Discarded", "Jun", "RiichiStick", "AgariTile", "RiichiTile", "IsTempFuriten", "IsRiichiFuriten", "IsDiscardFuriten" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Communication.Sync.WallStateMsg), global::RabiRiichi.Generated.Communication.Sync.WallStateMsg.Parser, new[]{ "Doras", "Remaining", "RinshanRemaining" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg), global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg.Parser, new[]{ "Id", "Wind", "Points", "Hand" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Communication.Sync.GameStateMsg), global::RabiRiichi.Generated.Communication.Sync.GameStateMsg.Parser, new[]{ "Config", "Info", "Wall", "Players" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerHandStateMsg : pb::IMessage<PlayerHandStateMsg> {
    private static readonly pb::MessageParser<PlayerHandStateMsg> _parser = new pb::MessageParser<PlayerHandStateMsg>(() => new PlayerHandStateMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerHandStateMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Communication.Sync.GameStateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerHandStateMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerHandStateMsg(PlayerHandStateMsg other) : this() {
      freeTiles_ = other.freeTiles_.Clone();
      called_ = other.called_.Clone();
      discarded_ = other.discarded_.Clone();
      jun_ = other.jun_;
      riichiStick_ = other.riichiStick_;
      agariTile_ = other.agariTile_ != null ? other.agariTile_.Clone() : null;
      riichiTile_ = other.riichiTile_ != null ? other.riichiTile_.Clone() : null;
      isTempFuriten_ = other.isTempFuriten_;
      isRiichiFuriten_ = other.isRiichiFuriten_;
      isDiscardFuriten_ = other.isDiscardFuriten_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerHandStateMsg Clone() {
      return new PlayerHandStateMsg(this);
    }

    /// <summary>Field number for the "free_tiles" field.</summary>
    public const int FreeTilesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::RabiRiichi.Generated.Core.GameTileMsg> _repeated_freeTiles_codec
        = pb::FieldCodec.ForMessage(10, global::RabiRiichi.Generated.Core.GameTileMsg.Parser);
    private readonly pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> freeTiles_ = new pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> FreeTiles {
      get { return freeTiles_; }
    }

    /// <summary>Field number for the "called" field.</summary>
    public const int CalledFieldNumber = 2;
    private static readonly pb::FieldCodec<global::RabiRiichi.Generated.Core.MenLikeMsg> _repeated_called_codec
        = pb::FieldCodec.ForMessage(18, global::RabiRiichi.Generated.Core.MenLikeMsg.Parser);
    private readonly pbc::RepeatedField<global::RabiRiichi.Generated.Core.MenLikeMsg> called_ = new pbc::RepeatedField<global::RabiRiichi.Generated.Core.MenLikeMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::RabiRiichi.Generated.Core.MenLikeMsg> Called {
      get { return called_; }
    }

    /// <summary>Field number for the "discarded" field.</summary>
    public const int DiscardedFieldNumber = 3;
    private static readonly pb::FieldCodec<global::RabiRiichi.Generated.Core.GameTileMsg> _repeated_discarded_codec
        = pb::FieldCodec.ForMessage(26, global::RabiRiichi.Generated.Core.GameTileMsg.Parser);
    private readonly pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> discarded_ = new pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> Discarded {
      get { return discarded_; }
    }

    /// <summary>Field number for the "jun" field.</summary>
    public const int JunFieldNumber = 4;
    private int jun_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Jun {
      get { return jun_; }
      set {
        jun_ = value;
      }
    }

    /// <summary>Field number for the "riichi_stick" field.</summary>
    public const int RiichiStickFieldNumber = 5;
    private int riichiStick_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RiichiStick {
      get { return riichiStick_; }
      set {
        riichiStick_ = value;
      }
    }

    /// <summary>Field number for the "agari_tile" field.</summary>
    public const int AgariTileFieldNumber = 6;
    private global::RabiRiichi.Generated.Core.GameTileMsg agariTile_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Core.GameTileMsg AgariTile {
      get { return agariTile_; }
      set {
        agariTile_ = value;
      }
    }

    /// <summary>Field number for the "riichi_tile" field.</summary>
    public const int RiichiTileFieldNumber = 7;
    private global::RabiRiichi.Generated.Core.GameTileMsg riichiTile_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Core.GameTileMsg RiichiTile {
      get { return riichiTile_; }
      set {
        riichiTile_ = value;
      }
    }

    /// <summary>Field number for the "is_temp_furiten" field.</summary>
    public const int IsTempFuritenFieldNumber = 8;
    private bool isTempFuriten_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsTempFuriten {
      get { return isTempFuriten_; }
      set {
        isTempFuriten_ = value;
      }
    }

    /// <summary>Field number for the "is_riichi_furiten" field.</summary>
    public const int IsRiichiFuritenFieldNumber = 9;
    private bool isRiichiFuriten_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsRiichiFuriten {
      get { return isRiichiFuriten_; }
      set {
        isRiichiFuriten_ = value;
      }
    }

    /// <summary>Field number for the "is_discard_furiten" field.</summary>
    public const int IsDiscardFuritenFieldNumber = 10;
    private bool isDiscardFuriten_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDiscardFuriten {
      get { return isDiscardFuriten_; }
      set {
        isDiscardFuriten_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerHandStateMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerHandStateMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!freeTiles_.Equals(other.freeTiles_)) return false;
      if(!called_.Equals(other.called_)) return false;
      if(!discarded_.Equals(other.discarded_)) return false;
      if (Jun != other.Jun) return false;
      if (RiichiStick != other.RiichiStick) return false;
      if (!object.Equals(AgariTile, other.AgariTile)) return false;
      if (!object.Equals(RiichiTile, other.RiichiTile)) return false;
      if (IsTempFuriten != other.IsTempFuriten) return false;
      if (IsRiichiFuriten != other.IsRiichiFuriten) return false;
      if (IsDiscardFuriten != other.IsDiscardFuriten) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= freeTiles_.GetHashCode();
      hash ^= called_.GetHashCode();
      hash ^= discarded_.GetHashCode();
      if (Jun != 0) hash ^= Jun.GetHashCode();
      if (RiichiStick != 0) hash ^= RiichiStick.GetHashCode();
      if (agariTile_ != null) hash ^= AgariTile.GetHashCode();
      if (riichiTile_ != null) hash ^= RiichiTile.GetHashCode();
      if (IsTempFuriten != false) hash ^= IsTempFuriten.GetHashCode();
      if (IsRiichiFuriten != false) hash ^= IsRiichiFuriten.GetHashCode();
      if (IsDiscardFuriten != false) hash ^= IsDiscardFuriten.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      freeTiles_.WriteTo(output, _repeated_freeTiles_codec);
      called_.WriteTo(output, _repeated_called_codec);
      discarded_.WriteTo(output, _repeated_discarded_codec);
      if (Jun != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Jun);
      }
      if (RiichiStick != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(RiichiStick);
      }
      if (agariTile_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AgariTile);
      }
      if (riichiTile_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(RiichiTile);
      }
      if (IsTempFuriten != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTempFuriten);
      }
      if (IsRiichiFuriten != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsRiichiFuriten);
      }
      if (IsDiscardFuriten != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsDiscardFuriten);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += freeTiles_.CalculateSize(_repeated_freeTiles_codec);
      size += called_.CalculateSize(_repeated_called_codec);
      size += discarded_.CalculateSize(_repeated_discarded_codec);
      if (Jun != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Jun);
      }
      if (RiichiStick != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RiichiStick);
      }
      if (agariTile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AgariTile);
      }
      if (riichiTile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RiichiTile);
      }
      if (IsTempFuriten != false) {
        size += 1 + 1;
      }
      if (IsRiichiFuriten != false) {
        size += 1 + 1;
      }
      if (IsDiscardFuriten != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerHandStateMsg other) {
      if (other == null) {
        return;
      }
      freeTiles_.Add(other.freeTiles_);
      called_.Add(other.called_);
      discarded_.Add(other.discarded_);
      if (other.Jun != 0) {
        Jun = other.Jun;
      }
      if (other.RiichiStick != 0) {
        RiichiStick = other.RiichiStick;
      }
      if (other.agariTile_ != null) {
        if (agariTile_ == null) {
          agariTile_ = new global::RabiRiichi.Generated.Core.GameTileMsg();
        }
        AgariTile.MergeFrom(other.AgariTile);
      }
      if (other.riichiTile_ != null) {
        if (riichiTile_ == null) {
          riichiTile_ = new global::RabiRiichi.Generated.Core.GameTileMsg();
        }
        RiichiTile.MergeFrom(other.RiichiTile);
      }
      if (other.IsTempFuriten != false) {
        IsTempFuriten = other.IsTempFuriten;
      }
      if (other.IsRiichiFuriten != false) {
        IsRiichiFuriten = other.IsRiichiFuriten;
      }
      if (other.IsDiscardFuriten != false) {
        IsDiscardFuriten = other.IsDiscardFuriten;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            freeTiles_.AddEntriesFrom(input, _repeated_freeTiles_codec);
            break;
          }
          case 18: {
            called_.AddEntriesFrom(input, _repeated_called_codec);
            break;
          }
          case 26: {
            discarded_.AddEntriesFrom(input, _repeated_discarded_codec);
            break;
          }
          case 32: {
            Jun = input.ReadInt32();
            break;
          }
          case 40: {
            RiichiStick = input.ReadInt32();
            break;
          }
          case 50: {
            if (agariTile_ == null) {
              agariTile_ = new global::RabiRiichi.Generated.Core.GameTileMsg();
            }
            input.ReadMessage(agariTile_);
            break;
          }
          case 58: {
            if (riichiTile_ == null) {
              riichiTile_ = new global::RabiRiichi.Generated.Core.GameTileMsg();
            }
            input.ReadMessage(riichiTile_);
            break;
          }
          case 64: {
            IsTempFuriten = input.ReadBool();
            break;
          }
          case 72: {
            IsRiichiFuriten = input.ReadBool();
            break;
          }
          case 80: {
            IsDiscardFuriten = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class WallStateMsg : pb::IMessage<WallStateMsg> {
    private static readonly pb::MessageParser<WallStateMsg> _parser = new pb::MessageParser<WallStateMsg>(() => new WallStateMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WallStateMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Communication.Sync.GameStateReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WallStateMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WallStateMsg(WallStateMsg other) : this() {
      doras_ = other.doras_.Clone();
      remaining_ = other.remaining_;
      rinshanRemaining_ = other.rinshanRemaining_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WallStateMsg Clone() {
      return new WallStateMsg(this);
    }

    /// <summary>Field number for the "doras" field.</summary>
    public const int DorasFieldNumber = 1;
    private static readonly pb::FieldCodec<global::RabiRiichi.Generated.Core.GameTileMsg> _repeated_doras_codec
        = pb::FieldCodec.ForMessage(10, global::RabiRiichi.Generated.Core.GameTileMsg.Parser);
    private readonly pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> doras_ = new pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> Doras {
      get { return doras_; }
    }

    /// <summary>Field number for the "remaining" field.</summary>
    public const int RemainingFieldNumber = 2;
    private int remaining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Remaining {
      get { return remaining_; }
      set {
        remaining_ = value;
      }
    }

    /// <summary>Field number for the "rinshan_remaining" field.</summary>
    public const int RinshanRemainingFieldNumber = 3;
    private int rinshanRemaining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RinshanRemaining {
      get { return rinshanRemaining_; }
      set {
        rinshanRemaining_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WallStateMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WallStateMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!doras_.Equals(other.doras_)) return false;
      if (Remaining != other.Remaining) return false;
      if (RinshanRemaining != other.RinshanRemaining) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= doras_.GetHashCode();
      if (Remaining != 0) hash ^= Remaining.GetHashCode();
      if (RinshanRemaining != 0) hash ^= RinshanRemaining.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      doras_.WriteTo(output, _repeated_doras_codec);
      if (Remaining != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Remaining);
      }
      if (RinshanRemaining != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RinshanRemaining);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += doras_.CalculateSize(_repeated_doras_codec);
      if (Remaining != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Remaining);
      }
      if (RinshanRemaining != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RinshanRemaining);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WallStateMsg other) {
      if (other == null) {
        return;
      }
      doras_.Add(other.doras_);
      if (other.Remaining != 0) {
        Remaining = other.Remaining;
      }
      if (other.RinshanRemaining != 0) {
        RinshanRemaining = other.RinshanRemaining;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            doras_.AddEntriesFrom(input, _repeated_doras_codec);
            break;
          }
          case 16: {
            Remaining = input.ReadInt32();
            break;
          }
          case 24: {
            RinshanRemaining = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PlayerStateMsg : pb::IMessage<PlayerStateMsg> {
    private static readonly pb::MessageParser<PlayerStateMsg> _parser = new pb::MessageParser<PlayerStateMsg>(() => new PlayerStateMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerStateMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Communication.Sync.GameStateReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerStateMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerStateMsg(PlayerStateMsg other) : this() {
      id_ = other.id_;
      wind_ = other.wind_;
      points_ = other.points_;
      hand_ = other.hand_ != null ? other.hand_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerStateMsg Clone() {
      return new PlayerStateMsg(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "wind" field.</summary>
    public const int WindFieldNumber = 2;
    private global::RabiRiichi.Generated.Core.Wind wind_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Core.Wind Wind {
      get { return wind_; }
      set {
        wind_ = value;
      }
    }

    /// <summary>Field number for the "points" field.</summary>
    public const int PointsFieldNumber = 3;
    private long points_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Points {
      get { return points_; }
      set {
        points_ = value;
      }
    }

    /// <summary>Field number for the "hand" field.</summary>
    public const int HandFieldNumber = 4;
    private global::RabiRiichi.Generated.Communication.Sync.PlayerHandStateMsg hand_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Communication.Sync.PlayerHandStateMsg Hand {
      get { return hand_; }
      set {
        hand_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerStateMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerStateMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Wind != other.Wind) return false;
      if (Points != other.Points) return false;
      if (!object.Equals(Hand, other.Hand)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Wind != 0) hash ^= Wind.GetHashCode();
      if (Points != 0L) hash ^= Points.GetHashCode();
      if (hand_ != null) hash ^= Hand.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Wind != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Wind);
      }
      if (Points != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Points);
      }
      if (hand_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Hand);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Wind != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Wind);
      }
      if (Points != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Points);
      }
      if (hand_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Hand);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerStateMsg other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Wind != 0) {
        Wind = other.Wind;
      }
      if (other.Points != 0L) {
        Points = other.Points;
      }
      if (other.hand_ != null) {
        if (hand_ == null) {
          hand_ = new global::RabiRiichi.Generated.Communication.Sync.PlayerHandStateMsg();
        }
        Hand.MergeFrom(other.Hand);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            wind_ = (global::RabiRiichi.Generated.Core.Wind) input.ReadEnum();
            break;
          }
          case 24: {
            Points = input.ReadInt64();
            break;
          }
          case 34: {
            if (hand_ == null) {
              hand_ = new global::RabiRiichi.Generated.Communication.Sync.PlayerHandStateMsg();
            }
            input.ReadMessage(hand_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GameStateMsg : pb::IMessage<GameStateMsg> {
    private static readonly pb::MessageParser<GameStateMsg> _parser = new pb::MessageParser<GameStateMsg>(() => new GameStateMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameStateMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Communication.Sync.GameStateReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameStateMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameStateMsg(GameStateMsg other) : this() {
      config_ = other.config_ != null ? other.config_.Clone() : null;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      wall_ = other.wall_ != null ? other.wall_.Clone() : null;
      players_ = other.players_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameStateMsg Clone() {
      return new GameStateMsg(this);
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 1;
    private global::RabiRiichi.Generated.Core.Config.GameConfigMsg config_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Core.Config.GameConfigMsg Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 2;
    private global::RabiRiichi.Generated.Core.GameInfoMsg info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Core.GameInfoMsg Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "wall" field.</summary>
    public const int WallFieldNumber = 3;
    private global::RabiRiichi.Generated.Communication.Sync.WallStateMsg wall_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Communication.Sync.WallStateMsg Wall {
      get { return wall_; }
      set {
        wall_ = value;
      }
    }

    /// <summary>Field number for the "players" field.</summary>
    public const int PlayersFieldNumber = 4;
    private static readonly pb::FieldCodec<global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg> _repeated_players_codec
        = pb::FieldCodec.ForMessage(34, global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg.Parser);
    private readonly pbc::RepeatedField<global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg> players_ = new pbc::RepeatedField<global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::RabiRiichi.Generated.Communication.Sync.PlayerStateMsg> Players {
      get { return players_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameStateMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameStateMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Config, other.Config)) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (!object.Equals(Wall, other.Wall)) return false;
      if(!players_.Equals(other.players_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (config_ != null) hash ^= Config.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (wall_ != null) hash ^= Wall.GetHashCode();
      hash ^= players_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (config_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Config);
      }
      if (info_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Info);
      }
      if (wall_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Wall);
      }
      players_.WriteTo(output, _repeated_players_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (wall_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Wall);
      }
      size += players_.CalculateSize(_repeated_players_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameStateMsg other) {
      if (other == null) {
        return;
      }
      if (other.config_ != null) {
        if (config_ == null) {
          config_ = new global::RabiRiichi.Generated.Core.Config.GameConfigMsg();
        }
        Config.MergeFrom(other.Config);
      }
      if (other.info_ != null) {
        if (info_ == null) {
          info_ = new global::RabiRiichi.Generated.Core.GameInfoMsg();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.wall_ != null) {
        if (wall_ == null) {
          wall_ = new global::RabiRiichi.Generated.Communication.Sync.WallStateMsg();
        }
        Wall.MergeFrom(other.Wall);
      }
      players_.Add(other.players_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (config_ == null) {
              config_ = new global::RabiRiichi.Generated.Core.Config.GameConfigMsg();
            }
            input.ReadMessage(config_);
            break;
          }
          case 18: {
            if (info_ == null) {
              info_ = new global::RabiRiichi.Generated.Core.GameInfoMsg();
            }
            input.ReadMessage(info_);
            break;
          }
          case 26: {
            if (wall_ == null) {
              wall_ = new global::RabiRiichi.Generated.Communication.Sync.WallStateMsg();
            }
            input.ReadMessage(wall_);
            break;
          }
          case 34: {
            players_.AddEntriesFrom(input, _repeated_players_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
