using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Domain
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Summary { get; set; }

        public RecipeCategory Category { get; set; }

        public Ingredient[] Ingredients { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string recipe = "";

            recipe += Name + '\n'
                    + Summary + "\n\n";

            foreach(Ingredient i in Ingredients)
            {
                recipe += i.ToString() + '\n';
            }

            recipe += '\n' + Description + '\n';

            return recipe;
        }
    }
}
