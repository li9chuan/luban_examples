
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{

public sealed class CompositeJsonTable2 :  Bright.Config.BeanBase 
{
    public CompositeJsonTable2(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        Y = _json.GetProperty("y").GetInt32();
    }

    public CompositeJsonTable2(int id, int y ) 
    {
        this.Id = id;
        this.Y = y;
    }

    public static CompositeJsonTable2 DeserializeCompositeJsonTable2(JsonElement _json)
    {
        return new test.CompositeJsonTable2(_json);
    }

    public int Id { get; private set; }
    public int Y { get; private set; }

    public const int __ID__ = 1566207895;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Y:" + Y + ","
        + "}";
    }
    }
}