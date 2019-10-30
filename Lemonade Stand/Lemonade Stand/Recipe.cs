using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe
    {
        //member variables(Has A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public int invLemons;
        public int invSugar;
        public int invIce;
        public int invCups;

        //constructor (Spawner)
        public Recipe()
        {

        }

        //member methods (Can Do)
        public void CreateRecipe(Inventory inventory)
        {
            Console.WriteLine("Lemons: " + inventory.lemons.Count);
            Console.WriteLine("Sugar Cubes: " + inventory.sugarCubes.Count);
            Console.WriteLine("Ice Cubes: " + inventory.iceCubes.Count);
            Console.WriteLine("Cups: " + inventory.cups.Count);
        }
    }
}
