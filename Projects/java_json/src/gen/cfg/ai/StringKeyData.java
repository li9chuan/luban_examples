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



public final class StringKeyData extends cfg.ai.KeyData {
    public StringKeyData(JsonObject __json__) { 
        super(__json__);
        value = __json__.get("value").getAsString();
    }

    public StringKeyData(String value ) {
        super();
        this.value = value;
    }

    public static StringKeyData deserializeStringKeyData(JsonObject __json__) {
        return new StringKeyData(__json__);
    }

    public final String value;

    public static final int __ID__ = -307888654;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "value:" + value + ","
        + "}";
    }
}