using SideLoader;
using System.Collections.Generic;

namespace TsarPlus
{


    public static class ItemList
    {
        public const int WEAPON_ENCHANT_ID_START = TsarPlus.ID_OFFSET - 100;
        public const int WEAPON_ENCHANT_COUNT = 17;
        public const int ARMOR_ENCHANT_ID_START = TsarPlus.ID_OFFSET - 120;
        public const int ARMOR_ENCHANT_COUNT = 14;


        public static List<SL_Item> items = new List<SL_Item>()
        {
            CreateBasicItem(4300140, TsarPlus.ID_OFFSET, "Gold Tincture", GOLD_TINCTURE_DESCRIPTION),
            CreateBasicItem(4300150, TsarPlus.ID_OFFSET-1, "Purified Gold Tincture", PURIFIED_GOLD_TINCTURE_DESCRIPTION),
            CreateItemTsarBase(),
            CreateTsarVarnish (-100, "Tsar Varnish", "adds 5 physical damage" ),
            CreateTsarVarnish (-101, "Lightning Tsar Varnish", "adds 5 lightning damage"),
            CreateTsarVarnish (-102, "Flaming Tsar Varnish", "adds 5 fire damage"),
            CreateTsarVarnish (-103, "Freezing Tsar Varnish", "adds 5 frost damage"),
            CreateTsarVarnish (-104, "Poisonous Tsar Varnish", "adds 5 decay damage"),
            CreateTsarVarnish (-105, "Spiritual Tsar Varnish", "adds 5 ethereal damage"),
            CreateTsarVarnish (-106, "Refined Tsar Varnish", "adds 5 raw damage"),
            CreateTsarVarnish (-107, "Hastening Tsar Varnish", "increases weapon speed by 0.1"),
            CreateTsarVarnish (-108, "Forceful Tsar Varnish", "adds 5 impact damage"),
            CreateTsarVarnish (-109, "Reinforcing Tsar Varnish", "adds 25 durability"),
            CreateTsarResin (-110, "Bloodletting Tsar Resin", "adds 10% extreme bleed buildup"),
            CreateTsarResin (-111, "Stunning Tsar Resin", "adds 10% dizzy buildup"),
            CreateTsarResin (-112, "Burning Tsar Resin", "adds 10% burning buildup"),
            CreateTsarResin (-113, "Chilling Tsar Resin", "adds 10% crippled buildup"),
            CreateTsarResin (-114, "Poisoning Tsar Resin", "adds 10% extreme poison buildup"),
            CreateTsarResin (-115, "Mystifying Tsar Resin", "adds 10% elemental vulnerability buildup"),
            CreateTsarResin (-116, "Draining Tsar Resin", "adds 10% sap and weaken buildup"),
            CreateTsarWax (-120, "Tsar Wax", "adds 5% physical defense"),
            CreateTsarWax (-121, "Electric Tsar Wax", "adds 5% lightning defense"),
            CreateTsarWax (-122, "Fire Tsar Wax", "adds 5% fire defense"),
            CreateTsarWax (-123, "Ice Tsar Wax", "adds 5% frost defense"),
            CreateTsarWax (-124, "Toxic Tsar Wax", "adds 5% decay defense"),
            CreateTsarWax (-125, "Ectoplasmic Tsar Wax", "adds 5% ethereal defense"),
            CreateTsarWax (-126, "Refined Tsar Wax", "adds 5 protection"),
            CreateTsarWax (-127, "Hastening Tsar Wax", "increases movement speed by 5%"),
            CreateTsarWax (-128, "Dampening Tsar Wax", "adds 5 impact defense"),
            CreateTsarWax (-129, "Reinforcing Tsar Wax", "adds 50 durability"),
            CreateTsarOil (-130, "Insulating Tsar Oil", "adds 5 hot and cold weather defense"),
            CreateTsarOil (-131, "Lubricating Tsar Oil", "adds 5% stamina reduction"),
            CreateTsarOil (-132, "Runic Tsar Oil", "adds 5% mana reduction"),
            CreateTsarOil (-133, "Mineral Tsar Oil", "adds 5% cooldown reduction"),
        };

        //-000 Gold Tincture
        //-001 Purified Gold Tincture
        //-002 Pure Tsar Elixir

        const string GOLD_TINCTURE_DESCRIPTION = "An impure tincture made of gold that needs further refining to be of use";
        const string PURIFIED_GOLD_TINCTURE_DESCRIPTION = "An expensive and well refined tincture made of gold, needed for the making of a rare shining elixir.";
        const string PURE_TSAR_ELIXIR_DESCRIPTION = "An expensive and rare elixir capable of making of a rare and powerful varnishes, resins, waxes, and oils.";
        const int PURE_TSAR_ELIXIR_ID = TsarPlus.ID_OFFSET - 2;

        static SL_Item CreateItemTsarBase()
        {
            return new SL_Item()
            {
                Target_ItemID = 5601010,
                New_ItemID = PURE_TSAR_ELIXIR_ID,
                Name = "Pure Tsar Elixir",
                Description = PURE_TSAR_ELIXIR_DESCRIPTION,
                LegacyItemID = -1,
                IsPickable = true,
                IsUsable = false,
                EffectTransforms = new SL_EffectTransform[] { },
                SLPackName = "TsarPlus",
                SubfolderName = "Pure Tsar Elixir"
            };
        }

        static SL_Item CreateBasicItem(int targetID, int id, string name, string description)
        {
            return new SL_Item()
            {
                Target_ItemID = targetID,
                New_ItemID = id,
                Name = name,
                Description = description,
                LegacyItemID = -1,
                IsPickable = true,
                IsUsable = false,
                EffectTransforms = new SL_EffectTransform[0]
            };
        }

        static SL_Item CreateTsarEnchantmentItem(int id, string name, string description)
        {
            return new SL_Item()
            {
                Target_ItemID = 5601010,
                New_ItemID = id+TsarPlus.ID_OFFSET,
                Name = name,
                Description = description,
                LegacyItemID = -1,
                IsPickable = true,
                IsUsable = true,
                QtyRemovedOnUse = 1,
                GroupItemInDisplay = true,
                CastType = Character.SpellCastType.SpellBindLight,
                CastLocomotionEnabled = false,
                CastSheatheRequired = 2,
                EffectTransforms = new SL_EffectTransform[] { },
                SLPackName = "TsarPlus",
                SubfolderName = "Pure Tsar Elixir"
            };
        }


        const string VARNISH_DESCRIPTION_START = "A thick fluid made from an expensive and rare elixir, that permanently ";
        const string VARNISH_DESCRIPTION_END = " when coated on a weapon.";
        static SL_Item CreateTsarVarnish(int id, string name, string effect)
        {
            return CreateTsarEnchantmentItem(id, name, VARNISH_DESCRIPTION_START + effect + VARNISH_DESCRIPTION_END);
        }

        const string RESIN_DESCRIPTION_START = "A rare copal resin made from an expensive and rare elixir, that permanently ";
        const string RESIN_DESCRIPTION_END = " when coated on a weapon.";
        static SL_Item CreateTsarResin(int id, string name, string effect)
        {
            return CreateTsarEnchantmentItem(id, name, RESIN_DESCRIPTION_START + effect + RESIN_DESCRIPTION_END);
        }

        const string WAX_DESCRIPTION_START = "A thick petrified wax made from an expensive and rare elixir, that permanently ";
        const string WAX_DESCRIPTION_END = " when coated on a piece of armor.";
        static SL_Item CreateTsarWax(int id, string name, string effect)
        {
            return CreateTsarEnchantmentItem(id, name, WAX_DESCRIPTION_START + effect + WAX_DESCRIPTION_END);
        }

        const string OIL_DESCRIPTION_START = "A rare oil made from an expensive and rare elixir, that permanently ";
        const string OIL_DESCRIPTION_END = " when coated on a piece of armor.";
        static SL_Item CreateTsarOil(int id, string name, string effect)
        {
            return CreateTsarEnchantmentItem(id, name, OIL_DESCRIPTION_START + effect + OIL_DESCRIPTION_END);
        }
    }
}
