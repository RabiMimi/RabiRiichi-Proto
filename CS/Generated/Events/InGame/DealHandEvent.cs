// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Events/InGame/DealHandEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Events.InGame {

  /// <summary>Holder for reflection information generated from Events/InGame/DealHandEvent.proto</summary>
  public static partial class DealHandEventReflection {

    #region Descriptor
    /// <summary>File descriptor for Events/InGame/DealHandEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DealHandEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFdmVudHMvSW5HYW1lL0RlYWxIYW5kRXZlbnQucHJvdG8aE0NvcmUvR2Ft",
            "ZVRpbGUucHJvdG8iQgoQRGVhbEhhbmRFdmVudE1zZxIRCglwbGF5ZXJfaWQY",
            "ASABKAUSGwoFdGlsZXMYAiADKAsyDC5HYW1lVGlsZU1zZ0IlqgIiUmFiaVJp",
            "aWNoaS5HZW5lcmF0ZWQuRXZlbnRzLkluR2FtZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::RabiRiichi.Generated.Core.GameTileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Events.InGame.DealHandEventMsg), global::RabiRiichi.Generated.Events.InGame.DealHandEventMsg.Parser, new[]{ "PlayerId", "Tiles" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DealHandEventMsg : pb::IMessage<DealHandEventMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DealHandEventMsg> _parser = new pb::MessageParser<DealHandEventMsg>(() => new DealHandEventMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DealHandEventMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Events.InGame.DealHandEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealHandEventMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealHandEventMsg(DealHandEventMsg other) : this() {
      playerId_ = other.playerId_;
      tiles_ = other.tiles_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DealHandEventMsg Clone() {
      return new DealHandEventMsg(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
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

    /// <summary>Field number for the "tiles" field.</summary>
    public const int TilesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::RabiRiichi.Generated.Core.GameTileMsg> _repeated_tiles_codec
        = pb::FieldCodec.ForMessage(18, global::RabiRiichi.Generated.Core.GameTileMsg.Parser);
    private readonly pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> tiles_ = new pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::RabiRiichi.Generated.Core.GameTileMsg> Tiles {
      get { return tiles_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DealHandEventMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DealHandEventMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if(!tiles_.Equals(other.tiles_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0) hash ^= PlayerId.GetHashCode();
      hash ^= tiles_.GetHashCode();
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
      tiles_.WriteTo(output, _repeated_tiles_codec);
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
      tiles_.WriteTo(ref output, _repeated_tiles_codec);
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
      size += tiles_.CalculateSize(_repeated_tiles_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DealHandEventMsg other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0) {
        PlayerId = other.PlayerId;
      }
      tiles_.Add(other.tiles_);
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
            tiles_.AddEntriesFrom(input, _repeated_tiles_codec);
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
            tiles_.AddEntriesFrom(ref input, _repeated_tiles_codec);
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
