//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.test
{

public sealed partial class TestString :  Bright.Config.BeanBase 
{
    public TestString(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        S1 = _buf.ReadString();
        Cs1 = test.CompactString.DeserializeCompactString(_buf);
        Cs2 = test.CompactString.DeserializeCompactString(_buf);
        PostInit();
    }

    public static TestString DeserializeTestString(ByteBuf _buf)
    {
        return new test.TestString(_buf);
    }

    public int Id { get; protected set; }
    public string S1 { get; protected set; }
    public test.CompactString Cs1 { get; protected set; }
    public test.CompactString Cs2 { get; protected set; }

    public const int __ID__ = 338485823;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Cs1?.Resolve(_tables);
        Cs2?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Cs1?.TranslateText(translator);
        Cs2?.TranslateText(translator);
    }

    public void Reload(TestString reloadData)
    {
        Id = reloadData.Id;
        S1 = reloadData.S1;
        if(Cs1==null)
        {
            Cs1 = reloadData.Cs1;
        }else
        {
            if(Cs1.GetTypeId() == reloadData.Cs1.GetTypeId())
            {
                Cs1.Reload(reloadData.Cs1);
            }else
            {
                typeof(TestString).GetProperty("Cs1").SetValue(this,reloadData.Cs1);
            }
        }
        if(Cs2==null)
        {
            Cs2 = reloadData.Cs2;
        }else
        {
            if(Cs2.GetTypeId() == reloadData.Cs2.GetTypeId())
            {
                Cs2.Reload(reloadData.Cs2);
            }else
            {
                typeof(TestString).GetProperty("Cs2").SetValue(this,reloadData.Cs2);
            }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "S1:" + S1 + ","
        + "Cs1:" + Cs1 + ","
        + "Cs2:" + Cs2 + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}