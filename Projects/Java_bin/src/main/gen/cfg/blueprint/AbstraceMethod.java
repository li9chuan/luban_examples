
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.blueprint;

import bright.serialization.*;



public final class AbstraceMethod extends cfg.blueprint.Method {
    public AbstraceMethod(ByteBuf _buf) { 
        super(_buf);
    }

    public AbstraceMethod(String name, String desc, boolean is_static, String return_type, java.util.ArrayList<cfg.blueprint.ParamInfo> parameters ) {
        super(name, desc, is_static, return_type, parameters);
    }



    public static final int __ID__ = -392137809;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "isStatic:" + isStatic + ","
        + "returnType:" + returnType + ","
        + "parameters:" + parameters + ","
        + "}";
    }
}