// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Patterns/ScoreCalcResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Patterns {

  /// <summary>Holder for reflection information generated from Patterns/ScoreCalcResult.proto</summary>
  public static partial class ScoreCalcResultReflection {

    #region Descriptor
    /// <summary>File descriptor for Patterns/ScoreCalcResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScoreCalcResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5QYXR0ZXJucy9TY29yZUNhbGNSZXN1bHQucHJvdG8ieAoSU2NvcmVDYWxj",
            "UmVzdWx0TXNnEgsKA2hhbhgBIAEoBRIMCgR5YWt1GAIgASgFEgoKAmZ1GAMg",
            "ASgFEg8KB3lha3VtYW4YBCABKAUSFAoMS2F6b2VZYWt1bWFuGAUgASgFEhQK",
            "DEZpbmFsWWFrdW1hbhgGIAEoBUIgqgIdUmFiaVJpaWNoaS5HZW5lcmF0ZWQu",
            "UGF0dGVybnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Patterns.ScoreCalcResultMsg), global::RabiRiichi.Generated.Patterns.ScoreCalcResultMsg.Parser, new[]{ "Han", "Yaku", "Fu", "Yakuman", "KazoeYakuman", "FinalYakuman" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScoreCalcResultMsg : pb::IMessage<ScoreCalcResultMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScoreCalcResultMsg> _parser = new pb::MessageParser<ScoreCalcResultMsg>(() => new ScoreCalcResultMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScoreCalcResultMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Patterns.ScoreCalcResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoreCalcResultMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoreCalcResultMsg(ScoreCalcResultMsg other) : this() {
      han_ = other.han_;
      yaku_ = other.yaku_;
      fu_ = other.fu_;
      yakuman_ = other.yakuman_;
      kazoeYakuman_ = other.kazoeYakuman_;
      finalYakuman_ = other.finalYakuman_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoreCalcResultMsg Clone() {
      return new ScoreCalcResultMsg(this);
    }

    /// <summary>Field number for the "han" field.</summary>
    public const int HanFieldNumber = 1;
    private int han_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Han {
      get { return han_; }
      set {
        han_ = value;
      }
    }

    /// <summary>Field number for the "yaku" field.</summary>
    public const int YakuFieldNumber = 2;
    private int yaku_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Yaku {
      get { return yaku_; }
      set {
        yaku_ = value;
      }
    }

    /// <summary>Field number for the "fu" field.</summary>
    public const int FuFieldNumber = 3;
    private int fu_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Fu {
      get { return fu_; }
      set {
        fu_ = value;
      }
    }

    /// <summary>Field number for the "yakuman" field.</summary>
    public const int YakumanFieldNumber = 4;
    private int yakuman_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Yakuman {
      get { return yakuman_; }
      set {
        yakuman_ = value;
      }
    }

    /// <summary>Field number for the "KazoeYakuman" field.</summary>
    public const int KazoeYakumanFieldNumber = 5;
    private int kazoeYakuman_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int KazoeYakuman {
      get { return kazoeYakuman_; }
      set {
        kazoeYakuman_ = value;
      }
    }

    /// <summary>Field number for the "FinalYakuman" field.</summary>
    public const int FinalYakumanFieldNumber = 6;
    private int finalYakuman_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FinalYakuman {
      get { return finalYakuman_; }
      set {
        finalYakuman_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScoreCalcResultMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScoreCalcResultMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Han != other.Han) return false;
      if (Yaku != other.Yaku) return false;
      if (Fu != other.Fu) return false;
      if (Yakuman != other.Yakuman) return false;
      if (KazoeYakuman != other.KazoeYakuman) return false;
      if (FinalYakuman != other.FinalYakuman) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Han != 0) hash ^= Han.GetHashCode();
      if (Yaku != 0) hash ^= Yaku.GetHashCode();
      if (Fu != 0) hash ^= Fu.GetHashCode();
      if (Yakuman != 0) hash ^= Yakuman.GetHashCode();
      if (KazoeYakuman != 0) hash ^= KazoeYakuman.GetHashCode();
      if (FinalYakuman != 0) hash ^= FinalYakuman.GetHashCode();
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
      if (Han != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Han);
      }
      if (Yaku != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Yaku);
      }
      if (Fu != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Fu);
      }
      if (Yakuman != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Yakuman);
      }
      if (KazoeYakuman != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(KazoeYakuman);
      }
      if (FinalYakuman != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(FinalYakuman);
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
      if (Han != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Han);
      }
      if (Yaku != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Yaku);
      }
      if (Fu != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Fu);
      }
      if (Yakuman != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Yakuman);
      }
      if (KazoeYakuman != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(KazoeYakuman);
      }
      if (FinalYakuman != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(FinalYakuman);
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
      if (Han != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Han);
      }
      if (Yaku != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Yaku);
      }
      if (Fu != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fu);
      }
      if (Yakuman != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Yakuman);
      }
      if (KazoeYakuman != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(KazoeYakuman);
      }
      if (FinalYakuman != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FinalYakuman);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScoreCalcResultMsg other) {
      if (other == null) {
        return;
      }
      if (other.Han != 0) {
        Han = other.Han;
      }
      if (other.Yaku != 0) {
        Yaku = other.Yaku;
      }
      if (other.Fu != 0) {
        Fu = other.Fu;
      }
      if (other.Yakuman != 0) {
        Yakuman = other.Yakuman;
      }
      if (other.KazoeYakuman != 0) {
        KazoeYakuman = other.KazoeYakuman;
      }
      if (other.FinalYakuman != 0) {
        FinalYakuman = other.FinalYakuman;
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
            Han = input.ReadInt32();
            break;
          }
          case 16: {
            Yaku = input.ReadInt32();
            break;
          }
          case 24: {
            Fu = input.ReadInt32();
            break;
          }
          case 32: {
            Yakuman = input.ReadInt32();
            break;
          }
          case 40: {
            KazoeYakuman = input.ReadInt32();
            break;
          }
          case 48: {
            FinalYakuman = input.ReadInt32();
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
            Han = input.ReadInt32();
            break;
          }
          case 16: {
            Yaku = input.ReadInt32();
            break;
          }
          case 24: {
            Fu = input.ReadInt32();
            break;
          }
          case 32: {
            Yakuman = input.ReadInt32();
            break;
          }
          case 40: {
            KazoeYakuman = input.ReadInt32();
            break;
          }
          case 48: {
            FinalYakuman = input.ReadInt32();
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
