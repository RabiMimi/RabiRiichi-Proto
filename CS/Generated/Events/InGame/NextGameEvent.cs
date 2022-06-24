// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Events/InGame/NextGameEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Events.InGame {

  /// <summary>Holder for reflection information generated from Events/InGame/NextGameEvent.proto</summary>
  public static partial class NextGameEventReflection {

    #region Descriptor
    /// <summary>File descriptor for Events/InGame/NextGameEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NextGameEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFdmVudHMvSW5HYW1lL05leHRHYW1lRXZlbnQucHJvdG8iZQoQTmV4dEdh",
            "bWVFdmVudE1zZxISCgpuZXh0X3JvdW5kGAEgASgFEhMKC25leHRfZGVhbGVy",
            "GAIgASgFEhIKCm5leHRfaG9uYmEYAyABKAUSFAoMcmlpY2hpX3N0aWNrGAQg",
            "ASgFQiWqAiJSYWJpUmlpY2hpLkdlbmVyYXRlZC5FdmVudHMuSW5HYW1lYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Events.InGame.NextGameEventMsg), global::RabiRiichi.Generated.Events.InGame.NextGameEventMsg.Parser, new[]{ "NextRound", "NextDealer", "NextHonba", "RiichiStick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NextGameEventMsg : pb::IMessage<NextGameEventMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NextGameEventMsg> _parser = new pb::MessageParser<NextGameEventMsg>(() => new NextGameEventMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NextGameEventMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Events.InGame.NextGameEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NextGameEventMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NextGameEventMsg(NextGameEventMsg other) : this() {
      nextRound_ = other.nextRound_;
      nextDealer_ = other.nextDealer_;
      nextHonba_ = other.nextHonba_;
      riichiStick_ = other.riichiStick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NextGameEventMsg Clone() {
      return new NextGameEventMsg(this);
    }

    /// <summary>Field number for the "next_round" field.</summary>
    public const int NextRoundFieldNumber = 1;
    private int nextRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NextRound {
      get { return nextRound_; }
      set {
        nextRound_ = value;
      }
    }

    /// <summary>Field number for the "next_dealer" field.</summary>
    public const int NextDealerFieldNumber = 2;
    private int nextDealer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NextDealer {
      get { return nextDealer_; }
      set {
        nextDealer_ = value;
      }
    }

    /// <summary>Field number for the "next_honba" field.</summary>
    public const int NextHonbaFieldNumber = 3;
    private int nextHonba_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NextHonba {
      get { return nextHonba_; }
      set {
        nextHonba_ = value;
      }
    }

    /// <summary>Field number for the "riichi_stick" field.</summary>
    public const int RiichiStickFieldNumber = 4;
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
      return Equals(other as NextGameEventMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NextGameEventMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NextRound != other.NextRound) return false;
      if (NextDealer != other.NextDealer) return false;
      if (NextHonba != other.NextHonba) return false;
      if (RiichiStick != other.RiichiStick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NextRound != 0) hash ^= NextRound.GetHashCode();
      if (NextDealer != 0) hash ^= NextDealer.GetHashCode();
      if (NextHonba != 0) hash ^= NextHonba.GetHashCode();
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
      if (NextRound != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NextRound);
      }
      if (NextDealer != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(NextDealer);
      }
      if (NextHonba != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NextHonba);
      }
      if (RiichiStick != 0) {
        output.WriteRawTag(32);
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
      if (NextRound != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NextRound);
      }
      if (NextDealer != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(NextDealer);
      }
      if (NextHonba != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(NextHonba);
      }
      if (RiichiStick != 0) {
        output.WriteRawTag(32);
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
      if (NextRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NextRound);
      }
      if (NextDealer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NextDealer);
      }
      if (NextHonba != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NextHonba);
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
    public void MergeFrom(NextGameEventMsg other) {
      if (other == null) {
        return;
      }
      if (other.NextRound != 0) {
        NextRound = other.NextRound;
      }
      if (other.NextDealer != 0) {
        NextDealer = other.NextDealer;
      }
      if (other.NextHonba != 0) {
        NextHonba = other.NextHonba;
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
            NextRound = input.ReadInt32();
            break;
          }
          case 16: {
            NextDealer = input.ReadInt32();
            break;
          }
          case 24: {
            NextHonba = input.ReadInt32();
            break;
          }
          case 32: {
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
            NextRound = input.ReadInt32();
            break;
          }
          case 16: {
            NextDealer = input.ReadInt32();
            break;
          }
          case 24: {
            NextHonba = input.ReadInt32();
            break;
          }
          case 32: {
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
