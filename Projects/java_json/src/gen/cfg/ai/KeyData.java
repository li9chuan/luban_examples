//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public abstract class KeyData {
    public KeyData(JsonObject __json__) { 
    }

    public KeyData() {
    }

    public static KeyData deserializeKeyData(JsonObject __json__) {
        switch (__json__.get("$type").getAsString()) {
            case "FloatKeyData": return new cfg.ai.FloatKeyData(__json__);
            case "IntKeyData": return new cfg.ai.IntKeyData(__json__);
            case "StringKeyData": return new cfg.ai.StringKeyData(__json__);
            case "BlackboardKeyData": return new cfg.ai.BlackboardKeyData(__json__);
            default: throw new bright.serialization.SerializationException();
        }
    }


    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "}";
    }
}
