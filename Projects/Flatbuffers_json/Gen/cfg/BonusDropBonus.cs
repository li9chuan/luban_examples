// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BonusDropBonus : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static BonusDropBonus GetRootAsBonusDropBonus(ByteBuffer _bb) { return GetRootAsBonusDropBonus(_bb, new BonusDropBonus()); }
  public static BonusDropBonus GetRootAsBonusDropBonus(ByteBuffer _bb, BonusDropBonus obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BonusDropBonus __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<cfg.BonusDropBonus> CreateBonusDropBonus(FlatBufferBuilder builder,
      int id = 0) {
    builder.StartTable(1);
    BonusDropBonus.AddId(builder, id);
    return BonusDropBonus.EndBonusDropBonus(builder);
  }

  public static void StartBonusDropBonus(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static Offset<cfg.BonusDropBonus> EndBonusDropBonus(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.BonusDropBonus>(o);
  }
};


}