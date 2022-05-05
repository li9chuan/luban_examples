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



namespace cfg.ai
{

public sealed partial class ChooseTarget :  ai.Service 
{
    public ChooseTarget(JsonElement _json)  : base(_json) 
    {
        ResultTargetKey = _json.GetProperty("result_target_key").GetString();
        PostInit();
    }

    public ChooseTarget(int id, string node_name, string result_target_key )  : base(id,node_name) 
    {
        this.ResultTargetKey = result_target_key;
        PostInit();
    }

    public static ChooseTarget DeserializeChooseTarget(JsonElement _json)
    {
        return new ai.ChooseTarget(_json);
    }

    public string ResultTargetKey { get; private set; }

    public const int __ID__ = 1601247918;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "ResultTargetKey:" + ResultTargetKey + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}