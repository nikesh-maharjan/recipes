using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipes.Abstract;
using Recipes.Domain;

namespace Recipes.Concrete
{
    class Application : IRunnable
    {
        RecipeBook ourRecipes;

        public Application()
        {
            ourRecipes = new RecipeBook(); // TODO make this load from a file

            // Pretending now...
            ourRecipes.AddRecipe(
                new Recipe
                {
                    Name = "My Great Recipe",
                    Summary = "The best recipe you've never had",
                    Description = "Combine the ingredients in a large bathtub. Simmer until gelatinous. Eat with spork.",
                    Category = RecipeCategory.Bread,
                    Ingredients = new[] { new Ingredient { Quantity = 5
                                                         , Unit     = "cups"
                                                         , Name     = "Sugar" }
                                        , new Ingredient { Quantity = 5
                                                         , Unit     = "loaves"
                                                         , Name     = "Bread" }
                                        , new Ingredient { Quantity = 0.5
                                                         , Unit     = "tbsp"
                                                         , Name     = "Yeast" }}
                });

            ourRecipes.AddRecipe(
             new Recipe { Name = "Water"
                         , Summary = "Water"
                         , Description = "HYDRATE"
                         , Category = RecipeCategory.Drinks
                         , Ingredients =
                               new[] { new Ingredient { Quantity = 1
                                                      , Unit = "atom"
                                                      , Name = "Oxygen" }
                                     , new Ingredient { Quantity = 2
                                                      , Unit = "atoms"
                                                      , Name = "Hydrogen" }}});
        }

        public void Run()
        {
            PrintRecipes(ourRecipes.RetrieveRecipe("Water"));

            ourRecipes.RemoveRecipe("Water");

            PrintRecipes(ourRecipes.RetrieveRecipe("Water"));

            PrintRecipes(ourRecipes.RetrieveRecipe(RecipeCategory.Bread));
        }

        void PrintRecipes(Recipe[] recipes)
        {
            if (recipes.Length == 0)
            {
                Console.WriteLine("No valid recipes found.");
            }
            else
            {
                Console.WriteLine($"{recipes.Length} recipes found");

                foreach (Recipe r in recipes)
                {
                    Console.WriteLine(r);
                    Console.WriteLine("\n--------------------\n");
                }
            }
        }
    }
}
