//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.error;
public enum EOperation {
    /**
     * 登出
     */
    LOGOUT(0),
    /**
     * 重启
     */
    RESTART(1),
    ;

    private final int value;

    public int getValue() {
        return value;
    }

    EOperation(int value) {
        this.value = value;
    }

    public static EOperation valueOf(int value) {
        if (value == 0) return LOGOUT;
        if (value == 1) return RESTART;
        throw new IllegalArgumentException("");
    }
}