// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Events/InGame/SetFuritenEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Events.InGame {

  /// <summary>Holder for reflection information generated from Events/InGame/SetFuritenEvent.proto</summary>
  public static partial class SetFuritenEventReflection {

    #region Descriptor
    /// <summary>File descriptor for Events/InGame/SetFuritenEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetFuritenEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNFdmVudHMvSW5HYW1lL1NldEZ1cml0ZW5FdmVudC5wcm90byJaChJTZXRG",
            "dXJpdGVuRXZlbnRNc2cSEAoIcGxheWVySWQYASABKAUSDwoHZnVyaXRlbhgC",
            "IAEoCBIhCgtmdXJpdGVuVHlwZRgDIAEoDjIMLkZ1cml0ZW5UeXBlKjAKC0Z1",
            "cml0ZW5UeXBlEggKBFRFTVAQABIKCgZSSUlDSEkQARILCgdESVNDQVJEEAJC",
            "JaoCIlJhYmlSaWljaGkuR2VuZXJhdGVkLkV2ZW50cy5JbkdhbWViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::RabiRiichi.Generated.Events.InGame.FuritenType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Events.InGame.SetFuritenEventMsg), global::RabiRiichi.Generated.Events.InGame.SetFuritenEventMsg.Parser, new[]{ "PlayerId", "Furiten", "FuritenType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum FuritenType {
    [pbr::OriginalName("TEMP")] Temp = 0,
    [pbr::OriginalName("RIICHI")] Riichi = 1,
    [pbr::OriginalName("DISCARD")] Discard = 2,
  }

  #endregion

  #region Messages
  public sealed partial class SetFuritenEventMsg : pb::IMessage<SetFuritenEventMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetFuritenEventMsg> _parser = new pb::MessageParser<SetFuritenEventMsg>(() => new SetFuritenEventMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetFuritenEventMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Events.InGame.SetFuritenEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetFuritenEventMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetFuritenEventMsg(SetFuritenEventMsg other) : this() {
      playerId_ = other.playerId_;
      furiten_ = other.furiten_;
      furitenType_ = other.furitenType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetFuritenEventMsg Clone() {
      return new SetFuritenEventMsg(this);
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

    /// <summary>Field number for the "furiten" field.</summary>
    public const int FuritenFieldNumber = 2;
    private bool furiten_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Furiten {
      get { return furiten_; }
      set {
        furiten_ = value;
      }
    }

    /// <summary>Field number for the "furitenType" field.</summary>
    public const int FuritenTypeFieldNumber = 3;
    private global::RabiRiichi.Generated.Events.InGame.FuritenType furitenType_ = global::RabiRiichi.Generated.Events.InGame.FuritenType.Temp;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RabiRiichi.Generated.Events.InGame.FuritenType FuritenType {
      get { return furitenType_; }
      set {
        furitenType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetFuritenEventMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetFuritenEventMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Furiten != other.Furiten) return false;
      if (FuritenType != other.FuritenType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0) hash ^= PlayerId.GetHashCode();
      if (Furiten != false) hash ^= Furiten.GetHashCode();
      if (FuritenType != global::RabiRiichi.Generated.Events.InGame.FuritenType.Temp) hash ^= FuritenType.GetHashCode();
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
      if (Furiten != false) {
        output.WriteRawTag(16);
        output.WriteBool(Furiten);
      }
      if (FuritenType != global::RabiRiichi.Generated.Events.InGame.FuritenType.Temp) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FuritenType);
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
      if (Furiten != false) {
        output.WriteRawTag(16);
        output.WriteBool(Furiten);
      }
      if (FuritenType != global::RabiRiichi.Generated.Events.InGame.FuritenType.Temp) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FuritenType);
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
      if (Furiten != false) {
        size += 1 + 1;
      }
      if (FuritenType != global::RabiRiichi.Generated.Events.InGame.FuritenType.Temp) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FuritenType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetFuritenEventMsg other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0) {
        PlayerId = other.PlayerId;
      }
      if (other.Furiten != false) {
        Furiten = other.Furiten;
      }
      if (other.FuritenType != global::RabiRiichi.Generated.Events.InGame.FuritenType.Temp) {
        FuritenType = other.FuritenType;
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
          case 16: {
            Furiten = input.ReadBool();
            break;
          }
          case 24: {
            FuritenType = (global::RabiRiichi.Generated.Events.InGame.FuritenType) input.ReadEnum();
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
          case 16: {
            Furiten = input.ReadBool();
            break;
          }
          case 24: {
            FuritenType = (global::RabiRiichi.Generated.Events.InGame.FuritenType) input.ReadEnum();
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
