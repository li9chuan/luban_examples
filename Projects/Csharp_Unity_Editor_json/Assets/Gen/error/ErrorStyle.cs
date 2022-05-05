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



namespace editor.cfg.error
{

public abstract partial class ErrorStyle :  Bright.Config.EditorBeanBase 
{
    public ErrorStyle()
    {
    }


    public static ErrorStyle LoadJsonErrorStyle(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        ErrorStyle obj;
        switch (type)
        {
            case "error.ErrorStyleTip":   
            case "ErrorStyleTip":obj = new error.ErrorStyleTip(); break;
            case "error.ErrorStyleMsgbox":   
            case "ErrorStyleMsgbox":obj = new error.ErrorStyleMsgbox(); break;
            case "error.ErrorStyleDlgOk":   
            case "ErrorStyleDlgOk":obj = new error.ErrorStyleDlgOk(); break;
            case "error.ErrorStyleDlgOkCancel":   
            case "ErrorStyleDlgOkCancel":obj = new error.ErrorStyleDlgOkCancel(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonErrorStyle(ErrorStyle _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

}
}