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



namespace editor.cfg.test
{

public sealed partial class DemoD5 :  test.DemoDynamic 
{
    public DemoD5()
    {
            Time = new test.DateTimeRange();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  X1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  Time = test.DateTimeRange.LoadJsonDateTimeRange(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "test.DemoD5";
        {
            _json["x1"] = new JSONNumber(X1);
        }
        {

            if (Time == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.DateTimeRange.SaveJsonDateTimeRange(Time, __bjson); _json["time"] = __bjson; }
        }
    }

    public static DemoD5 LoadJsonDemoD5(SimpleJSON.JSONNode _json)
    {
        DemoD5 obj = new test.DemoD5();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDemoD5(DemoD5 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public test.DateTimeRange Time { get; set; }

}
}