//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace editor.cfg.ai
{

public sealed partial class ExecuteTimeStatistic :  ai.Service 
{
    public ExecuteTimeStatistic()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["node_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  NodeName = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "ai.ExecuteTimeStatistic";
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (NodeName == null) { throw new System.ArgumentNullException(); }
            _json["node_name"] = new JSONString(NodeName);
        }
    }

    public static ExecuteTimeStatistic LoadJsonExecuteTimeStatistic(SimpleJSON.JSONNode _json)
    {
        ExecuteTimeStatistic obj = new ai.ExecuteTimeStatistic();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonExecuteTimeStatistic(ExecuteTimeStatistic _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

}
}