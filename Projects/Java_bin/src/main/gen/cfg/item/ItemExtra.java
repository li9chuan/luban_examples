
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.item;

import bright.serialization.*;



public abstract class ItemExtra {
    public ItemExtra(ByteBuf _buf) { 
        id = _buf.readInt();
    }

    public ItemExtra(int id ) {
        this.id = id;
    }

    public static ItemExtra deserializeItemExtra(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.item.TreasureBox.__ID__: return new cfg.item.TreasureBox(_buf);
            case cfg.item.InteractionItem.__ID__: return new cfg.item.InteractionItem(_buf);
            case cfg.item.Clothes.__ID__: return new cfg.item.Clothes(_buf);
            case cfg.item.DesignDrawing.__ID__: return new cfg.item.DesignDrawing(_buf);
            case cfg.item.Dymmy.__ID__: return new cfg.item.Dymmy(_buf);
            default: throw new SerializationException();
        }
    }

    public final int id;

    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "}";
    }
}