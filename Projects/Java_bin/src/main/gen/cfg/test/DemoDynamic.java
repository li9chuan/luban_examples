
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public abstract class DemoDynamic {
    public DemoDynamic(ByteBuf _buf) { 
        x1 = _buf.readInt();
    }

    public DemoDynamic(int x1 ) {
        this.x1 = x1;
    }

    public static DemoDynamic deserializeDemoDynamic(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.test.DemoD2.__ID__: return new cfg.test.DemoD2(_buf);
            case cfg.test.DemoE1.__ID__: return new cfg.test.DemoE1(_buf);
            case cfg.test.DemoD5.__ID__: return new cfg.test.DemoD5(_buf);
            default: throw new SerializationException();
        }
    }

    public final int x1;

    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "x1:" + x1 + ","
        + "}";
    }
}