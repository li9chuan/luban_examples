//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.item
{

    public enum EItemFunctionType
    {
        /// <summary>
        /// 更换手持物
        /// </summary>
        REPLACE_HANDHELD = 0,
        /// <summary>
        /// 使用设计图纸
        /// </summary>
        USE_DESIGN_DRAWING = 1,
    }

    public static partial class EItemFunctionType_Metadata
    {
        public static readonly Bright.Config.EditorEnumItemInfo REPLACE_HANDHELD = new Bright.Config.EditorEnumItemInfo("REPLACE_HANDHELD", "更换手持物", 0, "更换手持物");
        public static readonly Bright.Config.EditorEnumItemInfo USE_DESIGN_DRAWING = new Bright.Config.EditorEnumItemInfo("USE_DESIGN_DRAWING", "使用设计图纸", 1, "使用设计图纸");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            REPLACE_HANDHELD,
            USE_DESIGN_DRAWING,
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