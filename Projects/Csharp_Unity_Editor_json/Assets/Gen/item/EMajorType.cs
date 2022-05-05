//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg.item
{

    public enum EMajorType
    {
        /// <summary>
        /// 货币
        /// </summary>
        CURRENCY = 1,
        /// <summary>
        /// 服装
        /// </summary>
        CLOTH = 2,
        /// <summary>
        /// 任务
        /// </summary>
        QUEST = 3,
        /// <summary>
        /// 消耗品
        /// </summary>
        CONSUMABLES = 4,
        /// <summary>
        /// 宝箱
        /// </summary>
        TREASURE_BOX = 5,
        /// <summary>
        /// 成就和称谓
        /// </summary>
        ACHIEVEMENT_AND_TITLE = 6,
        /// <summary>
        /// 头像框
        /// </summary>
        HEAD_FRAME = 7,
        /// <summary>
        /// 语音
        /// </summary>
        VOICE = 8,
        /// <summary>
        /// 动作
        /// </summary>
        ACTION = 9,
        /// <summary>
        /// 扩容道具
        /// </summary>
        EXPANSION = 10,
        /// <summary>
        /// 制作材料
        /// </summary>
        MATERIAL = 11,
    }

    public static partial class EMajorType_Metadata
    {
        public static readonly Bright.Config.EditorEnumItemInfo CURRENCY = new Bright.Config.EditorEnumItemInfo("CURRENCY", "货币", 1, "货币");
        public static readonly Bright.Config.EditorEnumItemInfo CLOTH = new Bright.Config.EditorEnumItemInfo("CLOTH", "服装", 2, "服装");
        public static readonly Bright.Config.EditorEnumItemInfo QUEST = new Bright.Config.EditorEnumItemInfo("QUEST", "任务", 3, "任务");
        public static readonly Bright.Config.EditorEnumItemInfo CONSUMABLES = new Bright.Config.EditorEnumItemInfo("CONSUMABLES", "消耗品", 4, "消耗品");
        public static readonly Bright.Config.EditorEnumItemInfo TREASURE_BOX = new Bright.Config.EditorEnumItemInfo("TREASURE_BOX", "宝箱", 5, "宝箱");
        public static readonly Bright.Config.EditorEnumItemInfo ACHIEVEMENT_AND_TITLE = new Bright.Config.EditorEnumItemInfo("ACHIEVEMENT_AND_TITLE", "成就和称谓", 6, "成就和称谓");
        public static readonly Bright.Config.EditorEnumItemInfo HEAD_FRAME = new Bright.Config.EditorEnumItemInfo("HEAD_FRAME", "头像框", 7, "头像框");
        public static readonly Bright.Config.EditorEnumItemInfo VOICE = new Bright.Config.EditorEnumItemInfo("VOICE", "语音", 8, "语音");
        public static readonly Bright.Config.EditorEnumItemInfo ACTION = new Bright.Config.EditorEnumItemInfo("ACTION", "动作", 9, "动作");
        public static readonly Bright.Config.EditorEnumItemInfo EXPANSION = new Bright.Config.EditorEnumItemInfo("EXPANSION", "扩容道具", 10, "扩容道具");
        public static readonly Bright.Config.EditorEnumItemInfo MATERIAL = new Bright.Config.EditorEnumItemInfo("MATERIAL", "制作材料", 11, "制作材料");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            CURRENCY,
            CLOTH,
            QUEST,
            CONSUMABLES,
            TREASURE_BOX,
            ACHIEVEMENT_AND_TITLE,
            HEAD_FRAME,
            VOICE,
            ACTION,
            EXPANSION,
            MATERIAL,
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