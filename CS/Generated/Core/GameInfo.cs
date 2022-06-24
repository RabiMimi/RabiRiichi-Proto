// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Core/GameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Core {

  /// <summary>Holder for reflection information generated from Core/GameInfo.proto</summary>
  public static partial class GameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for Core/GameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNDb3JlL0dhbWVJbmZvLnByb3RvGhFDb3JlL1BsYXllci5wcm90byJ+CgtH",
            "YW1lSW5mb01zZxINCgVyb3VuZBgBIAEoBRITCgR3aW5kGAIgASgOMgUuV2lu",
            "ZBIOCgZkZWFsZXIYAyABKAUSDQoFaG9uYmEYBCABKAUSFgoOY3VycmVudF9w",
            "bGF5ZXIYBSABKAUSFAoMcmlpY2hpX3N0aWNrGAYgASgFQhyqAhlSYWJpUmlp",
            "Y2hpLkdlbmVyYXRlZC5Db3JlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::RabiRiichi.Generated.Core.PlayerReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Core.GameInfoMsg), global::RabiRiichi.Generated.Core.GameInfoMsg.Parser, new[]{ "Round", "Wind", "Dealer", "Honba", "CurrentPlayer", "RiichiStick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameInfoMsg : pb::IMessage<GameInfoMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameInfoMsg> _parser = new pb::MessageParser<GameInfoMsg>(() => new GameInfoMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameInfoMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Core.GameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameInfoMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameInfoMsg(GameInfoMsg other) : this() {
      round_ = other.round_;
      wind_ = other.wind_;
      dealer_ = other.dealer_;
      honba_ = other.honba_;
      currentPlayer_ = other.currentPlayer_;
      riichiStick_ = other.riichiStick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameInfoMsg Clone() {
      return new GameInfoMsg(this);
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 1;
    private int round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "wind" field.</summary>
    public const int WindFieldNumber = 2;
    private global::RabiRiichi.Generated.Core.Wind wind_ = global::RabiRiichi.Generated.Core.Wind.E;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RabiRiichi.Generated.Core.Wind Wind {
      get { return wind_; }
      set {
        wind_ = value;
      }
    }

    /// <summary>Field number for the "dealer" field.</summary>
    public const int DealerFieldNumber = 3;
    private int dealer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Dealer {
      get { return dealer_; }
      set {
        dealer_ = value;
      }
    }

    /// <summary>Field number for the "honba" field.</summary>
    public const int HonbaFieldNumber = 4;
    private int honba_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Honba {
      get { return honba_; }
      set {
        honba_ = value;
      }
    }

    /// <summary>Field number for the "current_player" field.</summary>
    public const int CurrentPlayerFieldNumber = 5;
    private int currentPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CurrentPlayer {
      get { return currentPlayer_; }
      set {
        currentPlayer_ = value;
      }
    }

    /// <summary>Field number for the "riichi_stick" field.</summary>
    public const int RiichiStickFieldNumber = 6;
    private int riichiStick_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int RiichiStick {
      get { return riichiStick_; }
      set {
        riichiStick_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameInfoMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameInfoMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Round != other.Round) return false;
      if (Wind != other.Wind) return false;
      if (Dealer != other.Dealer) return false;
      if (Honba != other.Honba) return false;
      if (CurrentPlayer != other.CurrentPlayer) return false;
      if (RiichiStick != other.RiichiStick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Round != 0) hash ^= Round.GetHashCode();
      if (Wind != global::RabiRiichi.Generated.Core.Wind.E) hash ^= Wind.GetHashCode();
      if (Dealer != 0) hash ^= Dealer.GetHashCode();
      if (Honba != 0) hash ^= Honba.GetHashCode();
      if (CurrentPlayer != 0) hash ^= CurrentPlayer.GetHashCode();
      if (RiichiStick != 0) hash ^= RiichiStick.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Round != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Round);
      }
      if (Wind != global::RabiRiichi.Generated.Core.Wind.E) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Wind);
      }
      if (Dealer != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Dealer);
      }
      if (Honba != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Honba);
      }
      if (CurrentPlayer != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(CurrentPlayer);
      }
      if (RiichiStick != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(RiichiStick);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Round != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Round);
      }
      if (Wind != global::RabiRiichi.Generated.Core.Wind.E) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Wind);
      }
      if (Dealer != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Dealer);
      }
      if (Honba != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Honba);
      }
      if (CurrentPlayer != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(CurrentPlayer);
      }
      if (RiichiStick != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(RiichiStick);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Round);
      }
      if (Wind != global::RabiRiichi.Generated.Core.Wind.E) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Wind);
      }
      if (Dealer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Dealer);
      }
      if (Honba != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Honba);
      }
      if (CurrentPlayer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurrentPlayer);
      }
      if (RiichiStick != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RiichiStick);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameInfoMsg other) {
      if (other == null) {
        return;
      }
      if (other.Round != 0) {
        Round = other.Round;
      }
      if (other.Wind != global::RabiRiichi.Generated.Core.Wind.E) {
        Wind = other.Wind;
      }
      if (other.Dealer != 0) {
        Dealer = other.Dealer;
      }
      if (other.Honba != 0) {
        Honba = other.Honba;
      }
      if (other.CurrentPlayer != 0) {
        CurrentPlayer = other.CurrentPlayer;
      }
      if (other.RiichiStick != 0) {
        RiichiStick = other.RiichiStick;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Round = input.ReadInt32();
            break;
          }
          case 16: {
            Wind = (global::RabiRiichi.Generated.Core.Wind) input.ReadEnum();
            break;
          }
          case 24: {
            Dealer = input.ReadInt32();
            break;
          }
          case 32: {
            Honba = input.ReadInt32();
            break;
          }
          case 40: {
            CurrentPlayer = input.ReadInt32();
            break;
          }
          case 48: {
            RiichiStick = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Round = input.ReadInt32();
            break;
          }
          case 16: {
            Wind = (global::RabiRiichi.Generated.Core.Wind) input.ReadEnum();
            break;
          }
          case 24: {
            Dealer = input.ReadInt32();
            break;
          }
          case 32: {
            Honba = input.ReadInt32();
            break;
          }
          case 40: {
            CurrentPlayer = input.ReadInt32();
            break;
          }
          case 48: {
            RiichiStick = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
