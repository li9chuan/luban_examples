//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.item
{

    public enum EUseType
    {
        /// <summary>
        /// 手动
        /// </summary>
        MANUAL = 0,
        /// <summary>
        /// 自动
        /// </summary>
        AUTO = 1,
    }

    public static partial class EUseType_Metadata
    {
        public static readonly Bright.Config.EditorEnumItemInfo MANUAL = new Bright.Config.EditorEnumItemInfo("MANUAL", "手动", 0, "手动");
        public static readonly Bright.Config.EditorEnumItemInfo AUTO = new Bright.Config.EditorEnumItemInfo("AUTO", "自动", 1, "自动");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            MANUAL,
            AUTO,
        };

        public static System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> GetItems() => __items;

        public static Bright.Config.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Bright.Config.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Bright.Config.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }
}