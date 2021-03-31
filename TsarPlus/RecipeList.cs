using SideLoader;
using System.Collections.Generic;

namespace TsarPlus
{
    public static class RecipeList
    {
        static SL_Recipe.Ingredient CRYSTAL_POWDER = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6600040" };
        static SL_Recipe.Ingredient COPAL = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6200060" };
        static SL_Recipe.Ingredient PETRIFIED_WOOD = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6400080" };
        static SL_Recipe.Ingredient GREASY_FERN = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6000020" };
        static SL_Recipe.Ingredient FIREFLY_POWDER = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6000010" };
        static SL_Recipe.Ingredient SEARED_ROOT = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "4100440" };
        static SL_Recipe.Ingredient LIVWEEDI = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6000030" };
        static SL_Recipe.Ingredient MIASMAPOD = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "4000250" };
        static SL_Recipe.Ingredient GHOST_EYE = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6000040" };
        static SL_Recipe.Ingredient PEACEMAKER_ELIXIR = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "4300270" };
        static SL_Recipe.Ingredient RAW_JEWEL_MEAT = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "4000260" };
        static SL_Recipe.Ingredient KRIMP_NUT = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "4000280" };
        static SL_Recipe.Ingredient BLUE_SAND = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6400110" };
        static SL_Recipe.Ingredient MANTICORE_TAIL = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6600150" };
        static SL_Recipe.Ingredient OBSIDIAN_SHARD = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6600200" };
        static SL_Recipe.Ingredient STINGLEAF = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6600012" };
        static SL_Recipe.Ingredient GOLD_INGOT = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6300030" };
        static SL_Recipe.Ingredient TSAR_STONE = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "6200010" };
        static SL_Recipe.Ingredient GOLD_TINCTURE = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "" + (TsarPlus.ID_OFFSET + 0) };
        static SL_Recipe.Ingredient PURIFIED_GOLD_TINCTURE = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "" + (TsarPlus.ID_OFFSET - 1) };
        static SL_Recipe.Ingredient PURE_TSAR_ELIXIR = new SL_Recipe.Ingredient() { Type = RecipeIngredient.ActionTypes.AddSpecificIngredient, SelectorValue = "" + (TsarPlus.ID_OFFSET - 2) };

        const string UID_PREFIX = "chief.";

        //public static SL_Recipe CreateRecipe()

        public static List<SL_Recipe> recipes = new List<SL_Recipe>()
        {
            CreateAlchemyRecipe(0, "GoldTincture",  GOLD_INGOT, GOLD_INGOT, GOLD_INGOT, GOLD_INGOT),
            CreateAlchemyRecipe(-1, "PurifiedGoldTincture", GOLD_TINCTURE, GOLD_TINCTURE, GOLD_TINCTURE, GOLD_TINCTURE),
            CreateAlchemyRecipe(-2, "PureTsarElixir", TSAR_STONE, PURIFIED_GOLD_TINCTURE, PURIFIED_GOLD_TINCTURE, PURIFIED_GOLD_TINCTURE),
            CreateTsarVarnishRecipe(-100, "Plain"), //crystal powder
            CreateTsarVarnishRecipe(-101, "Lightning", FIREFLY_POWDER),
            CreateTsarVarnishRecipe(-102, "Flaming", SEARED_ROOT),
            CreateTsarVarnishRecipe(-103, "Freezing", LIVWEEDI),
            CreateTsarVarnishRecipe(-104, "Poisonous", MIASMAPOD),
            CreateTsarVarnishRecipe(-105, "Spiritual", GHOST_EYE),
            CreateTsarVarnishRecipe(-106, "Refined", PEACEMAKER_ELIXIR),
            CreateTsarVarnishRecipe(-107, "Hastening", RAW_JEWEL_MEAT),
            CreateTsarVarnishRecipe(-108, "Forceful", KRIMP_NUT),
            CreateTsarVarnishRecipe(-109,"Reinforcing", BLUE_SAND),
            CreateTsarResinRecipe(-110, "Bloodletting"),//copal
            CreateTsarResinRecipe(-111, "Stunning", FIREFLY_POWDER),
            CreateTsarResinRecipe(-112, "Burning", SEARED_ROOT),
            CreateTsarResinRecipe(-113, "Chilling", LIVWEEDI),
            CreateTsarResinRecipe(-114, "Poisoning", MIASMAPOD),
            CreateTsarResinRecipe(-115, "Mystifying", GHOST_EYE),
            CreateTsarResinRecipe(-116, "Draining", PEACEMAKER_ELIXIR),
            CreateTsarWaxRecipe(-120, "Plain"),//petrified
            CreateTsarWaxRecipe(-121, "Electric", FIREFLY_POWDER),
            CreateTsarWaxRecipe(-122, "Fire", SEARED_ROOT),
            CreateTsarWaxRecipe(-123, "Ice", LIVWEEDI),
            CreateTsarWaxRecipe(-124, "Toxic", MIASMAPOD),
            CreateTsarWaxRecipe(-125, "Ectoplasmic", GHOST_EYE),
            CreateTsarWaxRecipe(-126, "Refined", PEACEMAKER_ELIXIR),
            CreateTsarWaxRecipe(-127, "Hastening", RAW_JEWEL_MEAT),
            CreateTsarWaxRecipe(-128, "Dampening", KRIMP_NUT),
            CreateTsarWaxRecipe(-129, "Reinforcing", BLUE_SAND),
            CreateTsarOilRecipe(-130, "Insulating", SEARED_ROOT, LIVWEEDI),//greasy
            CreateTsarOilRecipe(-131, "Lubricating", OBSIDIAN_SHARD),
            CreateTsarOilRecipe(-132, "Runic", MANTICORE_TAIL),
            CreateTsarOilRecipe(-133, "Mineral", STINGLEAF),
        };

        public static SL_Recipe CreateAlchemyRecipe(int resultID, string name,  SL_Recipe.Ingredient ingredient1 = null, SL_Recipe.Ingredient ingredient2 = null, SL_Recipe.Ingredient ingredient3 = null, SL_Recipe.Ingredient ingredient4 = null)
        {
            List<SL_Recipe.Ingredient> ingredients = new List<SL_Recipe.Ingredient>();

            if (ingredient1 != null)
                ingredients.Add(ingredient1);
            if (ingredient2 != null)
                ingredients.Add(ingredient2);
            if (ingredient3 != null)
                ingredients.Add(ingredient3);
            if (ingredient4 != null)
                ingredients.Add(ingredient4);

            return new SL_Recipe()
            {
                UID = UID_PREFIX + name,
                StationType = Recipe.CraftingType.Alchemy,
                Ingredients = ingredients,
                Results = new List<SL_Recipe.ItemQty>
                {
                    new SL_Recipe.ItemQty()
                    {
                        ItemID = resultID + TsarPlus.ID_OFFSET,
                        Quantity = 1
                    }
                }
            };
        }
        public static SL_Recipe CreateTsarVarnishRecipe (int resultID, string name,  SL_Recipe.Ingredient ingredient1 = null, SL_Recipe.Ingredient ingredient2 = null)
        {
            return CreateAlchemyRecipe(resultID, name + "TsarVarnish",  PURE_TSAR_ELIXIR, CRYSTAL_POWDER, ingredient1, ingredient2);
        }
        public static SL_Recipe CreateTsarResinRecipe(int resultID, string name, SL_Recipe.Ingredient ingredient1 = null, SL_Recipe.Ingredient ingredient2 = null)
        {
            return CreateAlchemyRecipe(resultID, name + "TsarResin", PURE_TSAR_ELIXIR, COPAL, ingredient1, ingredient2);
        }
        public static SL_Recipe CreateTsarWaxRecipe(int resultID, string name, SL_Recipe.Ingredient ingredient1 = null, SL_Recipe.Ingredient ingredient2 = null)
        {
            return CreateAlchemyRecipe(resultID, name + "TsarWax", PURE_TSAR_ELIXIR, PETRIFIED_WOOD, ingredient1, ingredient2);
        }
        public static SL_Recipe CreateTsarOilRecipe(int resultID, string name, SL_Recipe.Ingredient ingredient1 = null, SL_Recipe.Ingredient ingredient2 = null)
        {
            return CreateAlchemyRecipe(resultID, name + "TsarOil", PURE_TSAR_ELIXIR, GREASY_FERN, ingredient1, ingredient2);
        }
    }
}
