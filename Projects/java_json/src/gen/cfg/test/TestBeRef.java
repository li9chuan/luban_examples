//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class TestBeRef {
    public TestBeRef(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        count = __json__.get("count").getAsInt();
    }

    public TestBeRef(int id, int count ) {
        this.id = id;
        this.count = count;
    }

    public static TestBeRef deserializeTestBeRef(JsonObject __json__) {
        return new TestBeRef(__json__);
    }

    public final int id;
    public final int count;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "count:" + count + ","
        + "}";
    }
}