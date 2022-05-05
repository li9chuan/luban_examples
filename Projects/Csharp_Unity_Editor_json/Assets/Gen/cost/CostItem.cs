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



namespace editor.cfg.cost
{

public sealed partial class CostItem :  cost.Cost 
{
    public CostItem()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["item_id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  ItemId = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["amount"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Amount = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "cost.CostItem";
        {
            _json["item_id"] = new JSONNumber(ItemId);
        }
        {
            _json["amount"] = new JSONNumber(Amount);
        }
    }

    public static CostItem LoadJsonCostItem(SimpleJSON.JSONNode _json)
    {
        CostItem obj = new cost.CostItem();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonCostItem(CostItem _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int ItemId { get; set; }

    public int Amount { get; set; }

}
}