
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.bonus;

import bright.serialization.*;



public final class ProbabilityBonus extends cfg.bonus.Bonus {
    public ProbabilityBonus(ByteBuf _buf) { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());bonuses = new cfg.bonus.ProbabilityBonusInfo[n];for(int i = 0 ; i < n ; i++) { cfg.bonus.ProbabilityBonusInfo _e;_e = new cfg.bonus.ProbabilityBonusInfo(_buf); bonuses[i] = _e;}}
    }

    public ProbabilityBonus(cfg.bonus.ProbabilityBonusInfo[] bonuses ) {
        super();
        this.bonuses = bonuses;
    }


    public final cfg.bonus.ProbabilityBonusInfo[] bonuses;

    public static final int __ID__ = 359783161;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        for(cfg.bonus.ProbabilityBonusInfo _e : bonuses) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "bonuses:" + bonuses + ","
        + "}";
    }
}