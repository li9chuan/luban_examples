
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.cost;

import bright.serialization.*;



public final class CostItem extends cfg.cost.Cost {
    public CostItem(ByteBuf _buf) { 
        super(_buf);
        itemId = _buf.readInt();
        amount = _buf.readInt();
    }

    public CostItem(int item_id, int amount ) {
        super();
        this.itemId = item_id;
        this.amount = amount;
    }


    public final int itemId;
    public cfg.item.Item itemId_Ref;
    public final int amount;

    public static final int __ID__ = -1249440351;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        this.itemId_Ref = ((cfg.item.TbItem)_tables.get("item.TbItem")).get(itemId);
    }

    @Override
    public String toString() {
        return "{ "
        + "itemId:" + itemId + ","
        + "amount:" + amount + ","
        + "}";
    }
}