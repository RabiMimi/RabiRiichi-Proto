// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Events/InGame/DealerFirstTurnEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Events.InGame {

  /// <summary>Holder for reflection information generated from Events/InGame/DealerFirstTurnEvent.proto</summary>
  public static partial class DealerFirstTurnEventReflection {

    #region Descriptor
    /// <summary>File descriptor for Events/InGame/DealerFirstTurnEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DealerFirstTurnEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihFdmVudHMvSW5HYW1lL0RlYWxlckZpcnN0VHVybkV2ZW50LnByb3RvGhND",
            "b3JlL0dhbWVUaWxlLnByb3RvIksKF0RlYWxlckZpcnN0VHVybkV2ZW50TXNn",
            "EhAKCHBsYXllcklkGAEgASgFEh4KCGluY29taW5nGAIgASgLMgwuR2FtZVRp",
            "bGVNc2dCJaoCIlJhYmlSaWljaGkuR2VuZXJhdGVkLkV2ZW50cy5JbkdhbWVi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::RabiRiichi.Generated.Core.GameTileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Events.InGame.DealerFirstTurnEventMsg), global::RabiRiichi.Generated.Events.InGame.DealerFirstTurnEventMsg.Parser, new[]{ "PlayerId", "Incoming" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DealerFirstTurnEventMsg : pb::IMessage<DealerFirstTurnEventMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DealerFirstTurnEventMsg> _parser = new pb::MessageParser<DealerFirstTurnEventMsg>(() => new DealerFirstTurnEventMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DealerFirstTurnEventMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Events.InGame.DealerFirstTurnEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealerFirstTurnEventMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealerFirstTurnEventMsg(DealerFirstTurnEventMsg other) : this() {
      playerId_ = other.playerId_;
      incoming_ = other.incoming_ != null ? other.incoming_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealerFirstTurnEventMsg Clone() {
      return new DealerFirstTurnEventMsg(this);
    }

    /// <summary>Field number for the "playerId" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private int playerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    /// <summary>Field number for the "incoming" field.</summary>
    public const int IncomingFieldNumber = 2;
    private global::RabiRiichi.Generated.Core.GameTileMsg incoming_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RabiRiichi.Generated.Core.GameTileMsg Incoming {
      get { return incoming_; }
      set {
        incoming_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DealerFirstTurnEventMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DealerFirstTurnEventMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (!object.Equals(Incoming, other.Incoming)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0) hash ^= PlayerId.GetHashCode();
      if (incoming_ != null) hash ^= Incoming.GetHashCode();
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
      if (PlayerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerId);
      }
      if (incoming_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Incoming);
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
      if (PlayerId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerId);
      }
      if (incoming_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Incoming);
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
      if (PlayerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerId);
      }
      if (incoming_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Incoming);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DealerFirstTurnEventMsg other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0) {
        PlayerId = other.PlayerId;
      }
      if (other.incoming_ != null) {
        if (incoming_ == null) {
          Incoming = new global::RabiRiichi.Generated.Core.GameTileMsg();
        }
        Incoming.MergeFrom(other.Incoming);
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
            PlayerId = input.ReadInt32();
            break;
          }
          case 18: {
            if (incoming_ == null) {
              Incoming = new global::RabiRiichi.Generated.Core.GameTileMsg();
            }
            input.ReadMessage(Incoming);
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
            PlayerId = input.ReadInt32();
            break;
          }
          case 18: {
            if (incoming_ == null) {
              Incoming = new global::RabiRiichi.Generated.Core.GameTileMsg();
            }
            input.ReadMessage(Incoming);
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
