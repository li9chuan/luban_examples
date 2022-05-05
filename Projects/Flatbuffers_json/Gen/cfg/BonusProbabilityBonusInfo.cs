// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BonusProbabilityBonusInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static BonusProbabilityBonusInfo GetRootAsBonusProbabilityBonusInfo(ByteBuffer _bb) { return GetRootAsBonusProbabilityBonusInfo(_bb, new BonusProbabilityBonusInfo()); }
  public static BonusProbabilityBonusInfo GetRootAsBonusProbabilityBonusInfo(ByteBuffer _bb, BonusProbabilityBonusInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BonusProbabilityBonusInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.BonusBonus BonusType { get { int o = __p.__offset(4); return o != 0 ? (cfg.BonusBonus)__p.bb.Get(o + __p.bb_pos) : cfg.BonusBonus.NONE; } }
  public TTable? Bonus<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public cfg.BonusOneItem BonusAsBonusOneItem() { return Bonus<cfg.BonusOneItem>().Value; }
  public cfg.BonusOneItems BonusAsBonusOneItems() { return Bonus<cfg.BonusOneItems>().Value; }
  public cfg.BonusItem BonusAsBonusItem() { return Bonus<cfg.BonusItem>().Value; }
  public cfg.BonusItems BonusAsBonusItems() { return Bonus<cfg.BonusItems>().Value; }
  public cfg.BonusCoefficientItem BonusAsBonusCoefficientItem() { return Bonus<cfg.BonusCoefficientItem>().Value; }
  public cfg.BonusWeightItems BonusAsBonusWeightItems() { return Bonus<cfg.BonusWeightItems>().Value; }
  public cfg.BonusProbabilityItems BonusAsBonusProbabilityItems() { return Bonus<cfg.BonusProbabilityItems>().Value; }
  public cfg.BonusMultiBonus BonusAsBonusMultiBonus() { return Bonus<cfg.BonusMultiBonus>().Value; }
  public cfg.BonusProbabilityBonus BonusAsBonusProbabilityBonus() { return Bonus<cfg.BonusProbabilityBonus>().Value; }
  public cfg.BonusWeightBonus BonusAsBonusWeightBonus() { return Bonus<cfg.BonusWeightBonus>().Value; }
  public cfg.BonusDropBonus BonusAsBonusDropBonus() { return Bonus<cfg.BonusDropBonus>().Value; }
  public float Probability { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<cfg.BonusProbabilityBonusInfo> CreateBonusProbabilityBonusInfo(FlatBufferBuilder builder,
      cfg.BonusBonus bonus_type = cfg.BonusBonus.NONE,
      int bonusOffset = 0,
      float probability = 0.0f) {
    builder.StartTable(3);
    BonusProbabilityBonusInfo.AddProbability(builder, probability);
    BonusProbabilityBonusInfo.AddBonus(builder, bonusOffset);
    BonusProbabilityBonusInfo.AddBonusType(builder, bonus_type);
    return BonusProbabilityBonusInfo.EndBonusProbabilityBonusInfo(builder);
  }

  public static void StartBonusProbabilityBonusInfo(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddBonusType(FlatBufferBuilder builder, cfg.BonusBonus bonusType) { builder.AddByte(0, (byte)bonusType, 0); }
  public static void AddBonus(FlatBufferBuilder builder, int bonusOffset) { builder.AddOffset(1, bonusOffset, 0); }
  public static void AddProbability(FlatBufferBuilder builder, float probability) { builder.AddFloat(2, probability, 0.0f); }
  public static Offset<cfg.BonusProbabilityBonusInfo> EndBonusProbabilityBonusInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 6);  // bonus
    return new Offset<cfg.BonusProbabilityBonusInfo>(o);
  }
};


}