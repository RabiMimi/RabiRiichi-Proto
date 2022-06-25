// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Core/Config/GameConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace RabiRiichi.Generated.Core.Config {

  /// <summary>Holder for reflection information generated from Core/Config/GameConfig.proto</summary>
  public static partial class GameConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for Core/Config/GameConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDb3JlL0NvbmZpZy9HYW1lQ29uZmlnLnByb3RvGhdDb3JlL0NvbmZpZy9F",
            "bnVtcy5wcm90bxogQ29yZS9Db25maWcvUG9pbnRUaHJlc2hvbGQucHJvdG8i",
            "tQIKDUdhbWVDb25maWdNc2cSFAoMcGxheWVyX2NvdW50GAEgASgFEhMKC3Rv",
            "dGFsX3JvdW5kGAIgASgFEg8KB21pbl9oYW4YAyABKAUSKwoPcG9pbnRfdGhy",
            "ZXNob2xkGAQgASgLMhIuUG9pbnRUaHJlc2hvbGRNc2cSFgoOcmVuY2hhbl9w",
            "b2xpY3kYBSABKAUSFwoPZW5kX2dhbWVfcG9saWN5GAYgASgFEhUKDWt1aWth",
            "ZV9wb2xpY3kYByABKAUSFQoNcmlpY2hpX3BvbGljeRgIIAEoBRITCgtkb3Jh",
            "X29wdGlvbhgJIAEoBRIUCgxhZ2FyaV9vcHRpb24YCiABKAUSFgoOc2Nvcmlu",
            "Z19vcHRpb24YCyABKAUSGQoRcnl1dWt5b2t1X3RyaWdnZXIYDCABKAVCI6oC",
            "IFJhYmlSaWljaGkuR2VuZXJhdGVkLkNvcmUuQ29uZmlnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::RabiRiichi.Generated.Core.Config.EnumsReflection.Descriptor, global::RabiRiichi.Generated.Core.Config.PointThresholdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::RabiRiichi.Generated.Core.Config.GameConfigMsg), global::RabiRiichi.Generated.Core.Config.GameConfigMsg.Parser, new[]{ "PlayerCount", "TotalRound", "MinHan", "PointThreshold", "RenchanPolicy", "EndGamePolicy", "KuikaePolicy", "RiichiPolicy", "DoraOption", "AgariOption", "ScoringOption", "RyuukyokuTrigger" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameConfigMsg : pb::IMessage<GameConfigMsg> {
    private static readonly pb::MessageParser<GameConfigMsg> _parser = new pb::MessageParser<GameConfigMsg>(() => new GameConfigMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameConfigMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::RabiRiichi.Generated.Core.Config.GameConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameConfigMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameConfigMsg(GameConfigMsg other) : this() {
      playerCount_ = other.playerCount_;
      totalRound_ = other.totalRound_;
      minHan_ = other.minHan_;
      pointThreshold_ = other.pointThreshold_ != null ? other.pointThreshold_.Clone() : null;
      renchanPolicy_ = other.renchanPolicy_;
      endGamePolicy_ = other.endGamePolicy_;
      kuikaePolicy_ = other.kuikaePolicy_;
      riichiPolicy_ = other.riichiPolicy_;
      doraOption_ = other.doraOption_;
      agariOption_ = other.agariOption_;
      scoringOption_ = other.scoringOption_;
      ryuukyokuTrigger_ = other.ryuukyokuTrigger_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameConfigMsg Clone() {
      return new GameConfigMsg(this);
    }

    /// <summary>Field number for the "player_count" field.</summary>
    public const int PlayerCountFieldNumber = 1;
    private int playerCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PlayerCount {
      get { return playerCount_; }
      set {
        playerCount_ = value;
      }
    }

    /// <summary>Field number for the "total_round" field.</summary>
    public const int TotalRoundFieldNumber = 2;
    private int totalRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalRound {
      get { return totalRound_; }
      set {
        totalRound_ = value;
      }
    }

    /// <summary>Field number for the "min_han" field.</summary>
    public const int MinHanFieldNumber = 3;
    private int minHan_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MinHan {
      get { return minHan_; }
      set {
        minHan_ = value;
      }
    }

    /// <summary>Field number for the "point_threshold" field.</summary>
    public const int PointThresholdFieldNumber = 4;
    private global::RabiRiichi.Generated.Core.Config.PointThresholdMsg pointThreshold_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::RabiRiichi.Generated.Core.Config.PointThresholdMsg PointThreshold {
      get { return pointThreshold_; }
      set {
        pointThreshold_ = value;
      }
    }

    /// <summary>Field number for the "renchan_policy" field.</summary>
    public const int RenchanPolicyFieldNumber = 5;
    private int renchanPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RenchanPolicy {
      get { return renchanPolicy_; }
      set {
        renchanPolicy_ = value;
      }
    }

    /// <summary>Field number for the "end_game_policy" field.</summary>
    public const int EndGamePolicyFieldNumber = 6;
    private int endGamePolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EndGamePolicy {
      get { return endGamePolicy_; }
      set {
        endGamePolicy_ = value;
      }
    }

    /// <summary>Field number for the "kuikae_policy" field.</summary>
    public const int KuikaePolicyFieldNumber = 7;
    private int kuikaePolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int KuikaePolicy {
      get { return kuikaePolicy_; }
      set {
        kuikaePolicy_ = value;
      }
    }

    /// <summary>Field number for the "riichi_policy" field.</summary>
    public const int RiichiPolicyFieldNumber = 8;
    private int riichiPolicy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RiichiPolicy {
      get { return riichiPolicy_; }
      set {
        riichiPolicy_ = value;
      }
    }

    /// <summary>Field number for the "dora_option" field.</summary>
    public const int DoraOptionFieldNumber = 9;
    private int doraOption_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DoraOption {
      get { return doraOption_; }
      set {
        doraOption_ = value;
      }
    }

    /// <summary>Field number for the "agari_option" field.</summary>
    public const int AgariOptionFieldNumber = 10;
    private int agariOption_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AgariOption {
      get { return agariOption_; }
      set {
        agariOption_ = value;
      }
    }

    /// <summary>Field number for the "scoring_option" field.</summary>
    public const int ScoringOptionFieldNumber = 11;
    private int scoringOption_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ScoringOption {
      get { return scoringOption_; }
      set {
        scoringOption_ = value;
      }
    }

    /// <summary>Field number for the "ryuukyoku_trigger" field.</summary>
    public const int RyuukyokuTriggerFieldNumber = 12;
    private int ryuukyokuTrigger_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RyuukyokuTrigger {
      get { return ryuukyokuTrigger_; }
      set {
        ryuukyokuTrigger_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameConfigMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameConfigMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerCount != other.PlayerCount) return false;
      if (TotalRound != other.TotalRound) return false;
      if (MinHan != other.MinHan) return false;
      if (!object.Equals(PointThreshold, other.PointThreshold)) return false;
      if (RenchanPolicy != other.RenchanPolicy) return false;
      if (EndGamePolicy != other.EndGamePolicy) return false;
      if (KuikaePolicy != other.KuikaePolicy) return false;
      if (RiichiPolicy != other.RiichiPolicy) return false;
      if (DoraOption != other.DoraOption) return false;
      if (AgariOption != other.AgariOption) return false;
      if (ScoringOption != other.ScoringOption) return false;
      if (RyuukyokuTrigger != other.RyuukyokuTrigger) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerCount != 0) hash ^= PlayerCount.GetHashCode();
      if (TotalRound != 0) hash ^= TotalRound.GetHashCode();
      if (MinHan != 0) hash ^= MinHan.GetHashCode();
      if (pointThreshold_ != null) hash ^= PointThreshold.GetHashCode();
      if (RenchanPolicy != 0) hash ^= RenchanPolicy.GetHashCode();
      if (EndGamePolicy != 0) hash ^= EndGamePolicy.GetHashCode();
      if (KuikaePolicy != 0) hash ^= KuikaePolicy.GetHashCode();
      if (RiichiPolicy != 0) hash ^= RiichiPolicy.GetHashCode();
      if (DoraOption != 0) hash ^= DoraOption.GetHashCode();
      if (AgariOption != 0) hash ^= AgariOption.GetHashCode();
      if (ScoringOption != 0) hash ^= ScoringOption.GetHashCode();
      if (RyuukyokuTrigger != 0) hash ^= RyuukyokuTrigger.GetHashCode();
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
      if (PlayerCount != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PlayerCount);
      }
      if (TotalRound != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TotalRound);
      }
      if (MinHan != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MinHan);
      }
      if (pointThreshold_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PointThreshold);
      }
      if (RenchanPolicy != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(RenchanPolicy);
      }
      if (EndGamePolicy != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(EndGamePolicy);
      }
      if (KuikaePolicy != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(KuikaePolicy);
      }
      if (RiichiPolicy != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(RiichiPolicy);
      }
      if (DoraOption != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(DoraOption);
      }
      if (AgariOption != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(AgariOption);
      }
      if (ScoringOption != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(ScoringOption);
      }
      if (RyuukyokuTrigger != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(RyuukyokuTrigger);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlayerCount);
      }
      if (TotalRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalRound);
      }
      if (MinHan != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinHan);
      }
      if (pointThreshold_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PointThreshold);
      }
      if (RenchanPolicy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RenchanPolicy);
      }
      if (EndGamePolicy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndGamePolicy);
      }
      if (KuikaePolicy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(KuikaePolicy);
      }
      if (RiichiPolicy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RiichiPolicy);
      }
      if (DoraOption != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DoraOption);
      }
      if (AgariOption != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AgariOption);
      }
      if (ScoringOption != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ScoringOption);
      }
      if (RyuukyokuTrigger != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RyuukyokuTrigger);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameConfigMsg other) {
      if (other == null) {
        return;
      }
      if (other.PlayerCount != 0) {
        PlayerCount = other.PlayerCount;
      }
      if (other.TotalRound != 0) {
        TotalRound = other.TotalRound;
      }
      if (other.MinHan != 0) {
        MinHan = other.MinHan;
      }
      if (other.pointThreshold_ != null) {
        if (pointThreshold_ == null) {
          pointThreshold_ = new global::RabiRiichi.Generated.Core.Config.PointThresholdMsg();
        }
        PointThreshold.MergeFrom(other.PointThreshold);
      }
      if (other.RenchanPolicy != 0) {
        RenchanPolicy = other.RenchanPolicy;
      }
      if (other.EndGamePolicy != 0) {
        EndGamePolicy = other.EndGamePolicy;
      }
      if (other.KuikaePolicy != 0) {
        KuikaePolicy = other.KuikaePolicy;
      }
      if (other.RiichiPolicy != 0) {
        RiichiPolicy = other.RiichiPolicy;
      }
      if (other.DoraOption != 0) {
        DoraOption = other.DoraOption;
      }
      if (other.AgariOption != 0) {
        AgariOption = other.AgariOption;
      }
      if (other.ScoringOption != 0) {
        ScoringOption = other.ScoringOption;
      }
      if (other.RyuukyokuTrigger != 0) {
        RyuukyokuTrigger = other.RyuukyokuTrigger;
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
            PlayerCount = input.ReadInt32();
            break;
          }
          case 16: {
            TotalRound = input.ReadInt32();
            break;
          }
          case 24: {
            MinHan = input.ReadInt32();
            break;
          }
          case 34: {
            if (pointThreshold_ == null) {
              pointThreshold_ = new global::RabiRiichi.Generated.Core.Config.PointThresholdMsg();
            }
            input.ReadMessage(pointThreshold_);
            break;
          }
          case 40: {
            RenchanPolicy = input.ReadInt32();
            break;
          }
          case 48: {
            EndGamePolicy = input.ReadInt32();
            break;
          }
          case 56: {
            KuikaePolicy = input.ReadInt32();
            break;
          }
          case 64: {
            RiichiPolicy = input.ReadInt32();
            break;
          }
          case 72: {
            DoraOption = input.ReadInt32();
            break;
          }
          case 80: {
            AgariOption = input.ReadInt32();
            break;
          }
          case 88: {
            ScoringOption = input.ReadInt32();
            break;
          }
          case 96: {
            RyuukyokuTrigger = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
