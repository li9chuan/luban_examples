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

public sealed partial class SepBean1 :  Bright.Config.EditorBeanBase 
{
    public SepBean1()
    {
            C = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["a"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  A = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["b"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  B = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["c"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  C = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "test.SepBean1";
        {
            _json["a"] = new JSONNumber(A);
        }
        {
            _json["b"] = new JSONNumber(B);
        }
        {

            if (C == null) { throw new System.ArgumentNullException(); }
            _json["c"] = new JSONString(C);
        }
    }

    public static SepBean1 LoadJsonSepBean1(SimpleJSON.JSONNode _json)
    {
        SepBean1 obj = new test.SepBean1();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonSepBean1(SepBean1 _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int A { get; set; }

    public int B { get; set; }

    public string C { get; set; }

}
}