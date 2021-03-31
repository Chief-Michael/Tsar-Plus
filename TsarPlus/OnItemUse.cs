using HarmonyLib;
using SideLoader.Helpers;
using System;


namespace TsarPlus
{

    [HarmonyPatch(typeof(Item),"OnUse", new Type[] { typeof(Character) })]
    public class OnItemUse
    {
        static Range weapon_enchanting_item_id_range = new Range(ItemList.WEAPON_ENCHANT_ID_START, ItemList.WEAPON_ENCHANT_COUNT);
        static Range armor_enchanting_item_id_range = new Range(ItemList.ARMOR_ENCHANT_ID_START, ItemList.WEAPON_ENCHANT_COUNT);

        [HarmonyPostfix]
        public static void Postfix(Item __instance, Character _targetChar)
        {
            CharacterInventory player_inventory = _targetChar.Inventory;
            if (armor_enchanting_item_id_range.Contains(__instance.ItemID))
            {
                Equipment toEnchant = player_inventory.GetEquippedItem(EquipmentSlot.EquipmentSlotIDs.Chest) as Equipment;
                if(toEnchant == null)
                    toEnchant = player_inventory.GetEquippedItem(EquipmentSlot.EquipmentSlotIDs.Helmet) as Equipment;

                if(toEnchant == null)
                    toEnchant = player_inventory.GetEquippedItem(EquipmentSlot.EquipmentSlotIDs.Foot) as Equipment;

                if (toEnchant != null)
                    toEnchant.AddEnchantment(__instance.ItemID + TsarPlus.ENCHANTMENT_OFFSET);
            }

            if(weapon_enchanting_item_id_range.Contains(__instance.ItemID))
            {
                Equipment weapon = _targetChar.CurrentWeapon;
                if(weapon != null)
                {
                    weapon.AddEnchantment(__instance.ItemID + TsarPlus.ENCHANTMENT_OFFSET);
                }

            }
        }

        struct Range 
        {
            public Range(int _min, int _count)
            {
                min = _min;
                max = _min - _count;
            }

            public bool Contains(int value)
            {
                return value <= min && value > max;
            }

            public int min;
            public int max;
        }
    }
}
