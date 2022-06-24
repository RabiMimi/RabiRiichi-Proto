// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Events/InGame/DrawTileEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Events.InGame {

  /// <summary>Holder for reflection information generated from Events/InGame/DrawTileEvent.proto</summary>
  public static partial class DrawTileEventReflection {

    #region Descriptor
    /// <summary>File descriptor for Events/InGame/DrawTileEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DrawTileEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFdmVudHMvSW5HYW1lL0RyYXdUaWxlRXZlbnQucHJvdG8aE0NvcmUvR2Ft",
            "ZVRpbGUucHJvdG8iXgoQRHJhd1RpbGVFdmVudE1zZxIRCglwbGF5ZXJfaWQY",
            "ASABKAUSGwoGc291cmNlGAIgASgOMgsuVGlsZVNvdXJjZRIaCgR0aWxlGAMg",
            "ASgLMgwuR2FtZVRpbGVNc2dCJaoCIlJhYmlSaWljaGkuR2VuZXJhdGVkLkV2",
            "ZW50cy5JbkdhbWViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::RabiRiichi.Generated.Core.GameTileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Events.InGame.DrawTileEventMsg), global::RabiRiichi.Generated.Events.InGame.DrawTileEventMsg.Parser, new[]{ "PlayerId", "Source", "Tile" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DrawTileEventMsg : pb::IMessage<DrawTileEventMsg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DrawTileEventMsg> _parser = new pb::MessageParser<DrawTileEventMsg>(() => new DrawTileEventMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DrawTileEventMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Events.InGame.DrawTileEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrawTileEventMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrawTileEventMsg(DrawTileEventMsg other) : this() {
      playerId_ = other.playerId_;
      source_ = other.source_;
      tile_ = other.tile_ != null ? other.tile_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DrawTileEventMsg Clone() {
      return new DrawTileEventMsg(this);
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

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 2;
    private global::RabiRiichi.Generated.Core.TileSource source_ = global::RabiRiichi.Generated.Core.TileSource.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RabiRiichi.Generated.Core.TileSource Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "tile" field.</summary>
    public const int TileFieldNumber = 3;
    private global::RabiRiichi.Generated.Core.GameTileMsg tile_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::RabiRiichi.Generated.Core.GameTileMsg Tile {
      get { return tile_; }
      set {
        tile_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DrawTileEventMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DrawTileEventMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      if (Source != other.Source) return false;
      if (!object.Equals(Tile, other.Tile)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId != 0) hash ^= PlayerId.GetHashCode();
      if (Source != global::RabiRiichi.Generated.Core.TileSource.None) hash ^= Source.GetHashCode();
      if (tile_ != null) hash ^= Tile.GetHashCode();
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
      if (Source != global::RabiRiichi.Generated.Core.TileSource.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Source);
      }
      if (tile_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Tile);
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
      if (Source != global::RabiRiichi.Generated.Core.TileSource.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Source);
      }
      if (tile_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Tile);
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
      if (Source != global::RabiRiichi.Generated.Core.TileSource.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (tile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Tile);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DrawTileEventMsg other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId != 0) {
        PlayerId = other.PlayerId;
      }
      if (other.Source != global::RabiRiichi.Generated.Core.TileSource.None) {
        Source = other.Source;
      }
      if (other.tile_ != null) {
        if (tile_ == null) {
          Tile = new global::RabiRiichi.Generated.Core.GameTileMsg();
        }
        Tile.MergeFrom(other.Tile);
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
            Source = (global::RabiRiichi.Generated.Core.TileSource) input.ReadEnum();
            break;
          }
          case 26: {
            if (tile_ == null) {
              Tile = new global::RabiRiichi.Generated.Core.GameTileMsg();
            }
            input.ReadMessage(Tile);
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
            Source = (global::RabiRiichi.Generated.Core.TileSource) input.ReadEnum();
            break;
          }
          case 26: {
            if (tile_ == null) {
              Tile = new global::RabiRiichi.Generated.Core.GameTileMsg();
            }
            input.ReadMessage(Tile);
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
