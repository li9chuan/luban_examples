//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.ai
{

    public enum EKeyType
    {
        BOOL = 1,
        INT = 2,
        FLOAT = 3,
        STRING = 4,
        VECTOR = 5,
        ROTATOR = 6,
        NAME = 7,
        CLASS = 8,
        ENUM = 9,
        OBJECT = 10,
    }

    public static partial class EKeyType_Metadata
    {
        public static readonly Bright.Config.EditorEnumItemInfo BOOL = new Bright.Config.EditorEnumItemInfo("BOOL", "", 1, "");
        public static readonly Bright.Config.EditorEnumItemInfo INT = new Bright.Config.EditorEnumItemInfo("INT", "", 2, "");
        public static readonly Bright.Config.EditorEnumItemInfo FLOAT = new Bright.Config.EditorEnumItemInfo("FLOAT", "", 3, "");
        public static readonly Bright.Config.EditorEnumItemInfo STRING = new Bright.Config.EditorEnumItemInfo("STRING", "", 4, "");
        public static readonly Bright.Config.EditorEnumItemInfo VECTOR = new Bright.Config.EditorEnumItemInfo("VECTOR", "", 5, "");
        public static readonly Bright.Config.EditorEnumItemInfo ROTATOR = new Bright.Config.EditorEnumItemInfo("ROTATOR", "", 6, "");
        public static readonly Bright.Config.EditorEnumItemInfo NAME = new Bright.Config.EditorEnumItemInfo("NAME", "", 7, "");
        public static readonly Bright.Config.EditorEnumItemInfo CLASS = new Bright.Config.EditorEnumItemInfo("CLASS", "", 8, "");
        public static readonly Bright.Config.EditorEnumItemInfo ENUM = new Bright.Config.EditorEnumItemInfo("ENUM", "", 9, "");
        public static readonly Bright.Config.EditorEnumItemInfo OBJECT = new Bright.Config.EditorEnumItemInfo("OBJECT", "", 10, "");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            BOOL,
            INT,
            FLOAT,
            STRING,
            VECTOR,
            ROTATOR,
            NAME,
            CLASS,
            ENUM,
            OBJECT,
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