// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ErrorErrorStyleTip : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static ErrorErrorStyleTip GetRootAsErrorErrorStyleTip(ByteBuffer _bb) { return GetRootAsErrorErrorStyleTip(_bb, new ErrorErrorStyleTip()); }
  public static ErrorErrorStyleTip GetRootAsErrorErrorStyleTip(ByteBuffer _bb, ErrorErrorStyleTip obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ErrorErrorStyleTip __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartErrorErrorStyleTip(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<cfg.ErrorErrorStyleTip> EndErrorErrorStyleTip(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.ErrorErrorStyleTip>(o);
  }
};


}