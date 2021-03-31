using SideLoader;
using System.Collections.Generic;

namespace TsarPlus
{
    public static class EnchantmentList
    {
        public static List<SL_EnchantmentRecipe> Enchantments = new List<SL_EnchantmentRecipe>()
        {
            CreateDamageEnchantment(-100, "Tsar Varnish", DamageType.Types.Physical),
            CreateDamageEnchantment(-101, "Lightning Tsar Varnish", DamageType.Types.Electric),
            CreateDamageEnchantment(-102, "Flaming Tsar Varnish", DamageType.Types.Fire),
            CreateDamageEnchantment(-103, "Freezing Tsar Varnish", DamageType.Types.Frost),
            CreateDamageEnchantment(-104, "Poisonous Tsar Varnish", DamageType.Types.Decay),
            CreateDamageEnchantment(-105, "Spiritual Tsar Varnish", DamageType.Types.Ethereal),
            CreateDamageEnchantment(-106, "Refined Tsar Varnish", DamageType.Types.Raw),
            CreateStatEnchantment(-107, "Hastening Tsar Varnish", Enchantment.Stat.AttackSpeed, 0.1f),
            CreateStatEnchantment(-108, "Forceful Tsar Varnish", Enchantment.Stat.Impact, 5f),
            CreateStatEnchantment(-109, "Reinforcing Tsar Varnish", Enchantment.Stat.Durability, 25f),
            CreateBuildupEnchantment(-110, "Bloodletting Tsar Resin", "Bleeding +"),
            CreateBuildupEnchantment(-111, "Stunning Tsar Resin", "Dizzy"),
            CreateBuildupEnchantment(-112, "Burning Tsar Resin", "Burning"),
            CreateBuildupEnchantment(-113, "Chilling Tsar Resin", "Cripple"),
            CreateBuildupEnchantment(-114, "Poisoning Tsar Resin", "Poisoned +"),
            CreateBuildupEnchantment(-115, "Mystifying Tsar Resin", "Elemental Vulnerability"),
            CreateBuildupEnchantment(-116, "Draining Tsar Resin", "Sapped", "Weaken"),
            CreateDamageResistEnchantment(-120, "Tsar Wax", DamageType.Types.Physical),
            CreateDamageResistEnchantment(-121, "Lightning Tsar Wax", DamageType.Types.Electric),
            CreateDamageResistEnchantment(-122, "Fire Tsar Wax", DamageType.Types.Fire),
            CreateDamageResistEnchantment(-123, "Ice Tsar Wax", DamageType.Types.Frost),
            CreateDamageResistEnchantment(-124, "Toxic Tsar Wax", DamageType.Types.Decay),
            CreateDamageResistEnchantment(-125, "Ectoplasmic Tsar Wax", DamageType.Types.Ethereal),
            CreateStatEnchantment(-126, "Refined Tsar Wax", Enchantment.Stat.Protection, 5f),
            CreateStatModifierEnchantment(-127, "Hastening Tsar Wax", Enchantment.Stat.MovementSpeed, 5f),
            CreateStatEnchantment(-128, "Dampening Tsar Wax", Enchantment.Stat.ImpactResistance, 5f),
            CreateStatEnchantment(-129, "Reinforcing Tsar Wax", Enchantment.Stat.Durability, 50f),
            CreateStatEnchantment(-130, "Insulating Tsar Wax", Enchantment.Stat.ColdProtection, 5f, Enchantment.Stat.HeatProtection, 5f),
            CreateStatModifierEnchantment(-131, "Lubricating Tsar Wax", Enchantment.Stat.StaminaCostReduction, 5f),
            CreateStatModifierEnchantment(-132, "Runic Tsar Wax", Enchantment.Stat.ManaCostReduction, 5f),
            CreateStatModifierEnchantment(-133, "Mineral Tsar Wax", Enchantment.Stat.CooldownReduction, 5f),
        };

        static SL_EnchantmentRecipe CreateDamageEnchantment(int id, string name, DamageType.Types type)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                FlatDamageAdded = new SL_Damage[]
                {
                    new SL_Damage()
                    {
                        Damage = 5,
                        Type = type
                    },
                },
                DamageResistanceBonus = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                StatModifications = new SL_EnchantmentRecipe.StatModification[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                Effects = new SL_EffectTransform[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]
                };
        }
        static SL_EnchantmentRecipe CreateStatEnchantment(int id, string name, Enchantment.Stat stat, float amount)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                StatModifications = new SL_EnchantmentRecipe.StatModification[]
                {
                    new SL_EnchantmentRecipe.StatModification()
                    {
                        Stat = stat,
                        Type = Enchantment.StatModification.BonusType.Bonus,
                        Value = amount
                    }
                },
                FlatDamageAdded = new SL_Damage[0],
                DamageResistanceBonus = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                Effects = new SL_EffectTransform[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]

            };
        }
        static SL_EnchantmentRecipe CreateStatModifierEnchantment(int id, string name, Enchantment.Stat stat, float amount)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                StatModifications = new SL_EnchantmentRecipe.StatModification[]
                {
                    new SL_EnchantmentRecipe.StatModification()
                    {
                        Stat = stat,
                        Type = Enchantment.StatModification.BonusType.Modifier,
                        Value = amount
                    }
                },
                FlatDamageAdded = new SL_Damage[0],
                DamageResistanceBonus = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                Effects = new SL_EffectTransform[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]

            };
        }
        static SL_EnchantmentRecipe CreateBuildupEnchantment(int id, string name, string status_effect)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                Effects = new SL_EffectTransform[]
                {
                    new SL_EffectTransform()
                    {
                        Effects = new SL_Effect[]
                        {
                            new SL_AddStatusEffectBuildUp()
                            {
                                Buildup = 10f,
                                StatusEffect = status_effect
                            }
                        },
                        TransformName = "Hit_"+name
                    }
                },
                FlatDamageAdded = new SL_Damage[0],
                DamageResistanceBonus = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                StatModifications = new SL_EnchantmentRecipe.StatModification[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]

            };
        }
        static SL_EnchantmentRecipe CreateBuildupEnchantment(int id, string name, string status_effect1, string status_effect2)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                Effects = new SL_EffectTransform[]
                {
                    new SL_EffectTransform()
                    {
                        Effects = new SL_Effect[]
                        {
                            new SL_AddStatusEffectBuildUp()
                            {
                                Buildup = 10,
                                StatusEffect = status_effect1
                            },
                            new SL_AddStatusEffectBuildUp()
                            {
                                Buildup = 10,
                                StatusEffect = status_effect2
                            }
                        },
                        TransformName = "Hit_"+name
                    }
                },
                FlatDamageAdded = new SL_Damage[0],
                DamageResistanceBonus = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                StatModifications = new SL_EnchantmentRecipe.StatModification[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]

            };
        }
        static SL_EnchantmentRecipe CreateDamageResistEnchantment(int id, string name, DamageType.Types type)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                DamageResistanceBonus = new SL_Damage[]
                {
                    new SL_Damage()
                    {
                        Damage = 5,
                        Type = type
                    },
                },
                FlatDamageAdded = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                StatModifications = new SL_EnchantmentRecipe.StatModification[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                Effects = new SL_EffectTransform[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]

            };
        }
        static SL_EnchantmentRecipe CreateStatEnchantment(int id, string name, Enchantment.Stat stat1, float amount1, Enchantment.Stat stat2, float amount2)
        {
            return new SL_EnchantmentRecipe
            {
                EnchantmentID = id + TsarPlus.ENCHANTMENT_OFFSET + TsarPlus.ID_OFFSET,
                Name = name,
                CompatibleEquipment = new SL_EnchantmentRecipe.EquipmentData()
                {
                    RequiredTag = "Item"
                },
                StatModifications = new SL_EnchantmentRecipe.StatModification[]
                {
                    new SL_EnchantmentRecipe.StatModification()
                    {
                        Stat = stat1,
                        Type = Enchantment.StatModification.BonusType.Bonus,
                        Value = amount1
                    },
                    new SL_EnchantmentRecipe.StatModification()
                    {
                        Stat = stat2,
                        Type = Enchantment.StatModification.BonusType.Bonus,
                        Value = amount2
                    }
                },
                FlatDamageAdded = new SL_Damage[0],
                DamageResistanceBonus = new SL_Damage[0],
                DamageModifierBonus = new SL_Damage[0],
                AddedDamages = new SL_EnchantmentRecipe.AdditionalDamage[0],
                Effects = new SL_EffectTransform[0],
                PillarDatas = new SL_EnchantmentRecipe.PillarData[0],
                Areas = new AreaManager.AreaEnum[0],
                WeatherConditions = new SL_EnchantmentRecipe.WeatherCondition[0],
                Temperature = new TemperatureSteps[0],
                TimeOfDay = new UnityEngine.Vector2[0]

            };
        }


        //-120 Tsar Wax(physical defense)
        //-121 Electric Tsar Wax
        //-122 Fire Tsar Wax
        //-123 Ice Tsar Wax
        //-124 Toxic Tsar Wax
        //-125 Ectoplasmic Tsar Wax
        //-126 Refined Tsar Wax(Protection)
        //-127 Hastening Tsar Wax 
        //-128 Dampening Tsar Wax
        //-129 Reinforcing Tsar Wax

        //-130 Insulating Tsar Oil(Hot/Cold Resist)
        //-131 Lubricating Tsar Oil(Stamina Cost Reduction)
        //-132 Runic Tsar Oil(Mana Cost Reduction)
        //-133 Mineral Tsar Oil(Cooldown Reduction)
    }
}
