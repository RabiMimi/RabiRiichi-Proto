// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RabiRiichi.Server/Messages/HeartBeat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Server.Generated.Messages {

  /// <summary>Holder for reflection information generated from RabiRiichi.Server/Messages/HeartBeat.proto</summary>
  public static partial class HeartBeatReflection {

    #region Descriptor
    /// <summary>File descriptor for RabiRiichi.Server/Messages/HeartBeat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeartBeatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipSYWJpUmlpY2hpLlNlcnZlci9NZXNzYWdlcy9IZWFydEJlYXQucHJvdG8i",
            "SAoSVHdvV2F5SGVhcnRCZWF0TXNnEgoKAmlkGAEgASgFEg4KBm1heF9pZBgC",
            "IAEoBRIWCg5yZXF1ZXN0aW5nX2lkcxgDIAMoBUInqgIkUmFiaVJpaWNoaS5T",
            "ZXJ2ZXIuR2VuZXJhdGVkLk1lc3NhZ2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Server.Generated.Messages.TwoWayHeartBeatMsg), global::RabiRiichi.Server.Generated.Messages.TwoWayHeartBeatMsg.Parser, new[]{ "Id", "MaxId", "RequestingIds" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TwoWayHeartBeatMsg : pb::IMessage<TwoWayHeartBeatMsg> {
    private static readonly pb::MessageParser<TwoWayHeartBeatMsg> _parser = new pb::MessageParser<TwoWayHeartBeatMsg>(() => new TwoWayHeartBeatMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TwoWayHeartBeatMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Server.Generated.Messages.HeartBeatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TwoWayHeartBeatMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TwoWayHeartBeatMsg(TwoWayHeartBeatMsg other) : this() {
      id_ = other.id_;
      maxId_ = other.maxId_;
      requestingIds_ = other.requestingIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TwoWayHeartBeatMsg Clone() {
      return new TwoWayHeartBeatMsg(this);
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

    /// <summary>Field number for the "max_id" field.</summary>
    public const int MaxIdFieldNumber = 2;
    private int maxId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxId {
      get { return maxId_; }
      set {
        maxId_ = value;
      }
    }

    /// <summary>Field number for the "requesting_ids" field.</summary>
    public const int RequestingIdsFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_requestingIds_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> requestingIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> RequestingIds {
      get { return requestingIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TwoWayHeartBeatMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TwoWayHeartBeatMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (MaxId != other.MaxId) return false;
      if(!requestingIds_.Equals(other.requestingIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (MaxId != 0) hash ^= MaxId.GetHashCode();
      hash ^= requestingIds_.GetHashCode();
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
      if (MaxId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxId);
      }
      requestingIds_.WriteTo(output, _repeated_requestingIds_codec);
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
      if (MaxId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxId);
      }
      size += requestingIds_.CalculateSize(_repeated_requestingIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TwoWayHeartBeatMsg other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.MaxId != 0) {
        MaxId = other.MaxId;
      }
      requestingIds_.Add(other.requestingIds_);
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
            MaxId = input.ReadInt32();
            break;
          }
          case 26:
          case 24: {
            requestingIds_.AddEntriesFrom(input, _repeated_requestingIds_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
