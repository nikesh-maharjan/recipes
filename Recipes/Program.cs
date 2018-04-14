using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Recipes.Abstract;
using Recipes.Concrete;

namespace Recipes
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunnable app = new Application();

            app.Run();
        }
    }
}
