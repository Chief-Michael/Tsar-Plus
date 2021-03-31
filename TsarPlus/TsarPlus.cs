using System;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using SideLoader;

namespace TsarPlus
{
    // Token: 0x02000002 RID: 2
    [BepInPlugin("com.Chief.TsarPlus", "TsarPlus", "1.0")]
    [BepInDependency("com.sinai.SideLoader")]
    public class TsarPlus : BaseUnityPlugin
    {
        public const int ID_OFFSET = -9000;
        public const int ID_RANGE = -1000;
        public const int ENCHANTMENT_OFFSET = -100;

        static TsarPlus singleton;

        internal void Awake()
        {
            singleton = this;
            foreach (SL_Item item in ItemList.items)
                item.ApplyTemplate();

            foreach (SL_Recipe recipe in RecipeList.recipes)
                recipe.ApplyTemplate();

            foreach (SL_EnchantmentRecipe enchantment in EnchantmentList.Enchantments)
                enchantment.ApplyTemplate();

            new Harmony("com.Chief.TsarPlus").PatchAll();
            Logger.Log(LogLevel.Message, "TsarPlus Installed");
        }

        public static void Log(string msg)
        {
            if(singleton != null)
            {
                singleton.Logger.Log(LogLevel.Message, msg);
            }
        }
    }
}
