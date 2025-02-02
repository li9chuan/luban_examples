//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.condition;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class TimeRange extends cfg.condition.Condition {
    public TimeRange(JsonObject __json__) { 
        super(__json__);
        dateTimeRange = new cfg.common.DateTimeRange(__json__.get("date_time_range").getAsJsonObject());
    }

    public TimeRange(cfg.common.DateTimeRange date_time_range ) {
        super();
        this.dateTimeRange = date_time_range;
    }

    public static TimeRange deserializeTimeRange(JsonObject __json__) {
        return new TimeRange(__json__);
    }

    public final cfg.common.DateTimeRange dateTimeRange;

    public static final int __ID__ = 1069033789;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        if (dateTimeRange != null) {dateTimeRange.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "dateTimeRange:" + dateTimeRange + ","
        + "}";
    }
}
