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
        Player player;
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        //constructor (Spawner)
        public Recipe()
        {

        }

        //member methods (Can Do)
        public void CreateRecipe()
        {
            //Find out how to access user input from Store to store here for further use
            recipe = player.inventory.lemons.Count;
            Console.WriteLine("Lemons: " + recipe);
        }
    }
}
