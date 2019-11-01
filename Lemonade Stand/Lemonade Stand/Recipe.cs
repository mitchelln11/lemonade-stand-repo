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

        public int remainingLemons;
        public int remainingSugarCubes;
        public int remainingIceCubes;

        //constructor (Spawner)
        public Recipe()
        {

        }

        //member methods (Can Do)
        public void CreateRecipe(Inventory inventory)
        {
            Console.WriteLine("How many lemons per pitcher?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            if (inventory.lemons.Count >= amountOfLemons );
            {
                Console.WriteLine(amountOfLemons + " lemons added to each pitcher \n");
            }
            
            Console.WriteLine("How many sugar cubes per pitcher?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            if (inventory.sugarCubes.Count >= amountOfSugarCubes);
            {
                Console.WriteLine(amountOfSugarCubes + " sugar cubes in each pitcher \n");
            }

            Console.WriteLine("How many ice cubes per pitcher?");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            if (inventory.iceCubes.Count >= amountOfIceCubes)
            {
                Console.WriteLine(amountOfIceCubes + " ice cubes in each pitcher \n");
            }
        }

        public void PricePerCup()
        {
            Console.WriteLine("What would you like the price to be per cup? (In cents - Ex: 16 = 0.16)");
            pricePerCup = Convert.ToInt32(Console.ReadLine());
            if (pricePerCup >= 99)
            {
                Console.WriteLine("Sorry, the government says you can't charge over 99 cents per cup. Try again.");
                PricePerCup();
            }
        }
    }
}
