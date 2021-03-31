//using HarmonyLib;
//using SideLoader.Helpers;
//using System.Collections.Generic;

//namespace TsarPlus
//{

//    [HarmonyPatch(typeof(Equipment), "AddEnchantment")]
//    public class AddEnchantment
//    {
//        [HarmonyPrefix]
//        public static void Prefix(Equipment __instance, int _enchantmentID, bool _fromSync = false)
//        {
//            Enchantment enchantment = ResourcesPrefabManager.Instance.GenerateEnchantment(_enchantmentID, __instance.transform);
//            if (enchantment)
//            {
//                enchantment.ApplyEnchantment(__instance);
//                EnchantmentRecipe enchantmentRecipeForID = RecipeManager.Instance.GetEnchantmentRecipeForID(_enchantmentID);
//                enchantment.AppliedIncenses = enchantmentRecipeForID.Incenses;
//                AtExtensions.GetField<List<int>, Equipment>(__instance, "m_enchantmentIDs").Add(_enchantmentID);
//                AtExtensions.GetField<List<Enchantment>, Equipment>(__instance, "m_activeEnchantments").Add(enchantment);
//                AtExtensions.SetField(__instance, "m_enchantmentsHaveChanged", !_fromSync);
//                if (!_fromSync)
//                {
//                    float durabilityRatio = __instance.DurabilityRatio;
//                    AtExtensions.Invoke<object, Equipment>(__instance, "RefreshEnchantmentModifiers");
//                    if (durabilityRatio != __instance.DurabilityRatio)
//                    {
//                        __instance.SetDurabilityRatio(durabilityRatio);
//                    }
//                }
//            }

//        }
//    }
//}
