using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        //member variables(Has A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;
        private int lemonAmountPrompt;
        private double lemonTotal;

        //constructor (Spawner)
        public Store()
        {
            pricePerLemon = 0.20;
            pricePerSugarCube = 0.10;
            pricePerIceCube = 0.02;
            pricePerCup = 0.05;
        }

        //member methods (Can Do)
        public void ProductToPurchase()
        {
            Console.WriteLine("What product would you like to purchase?");
        }

        public void AmountOfProduct(int amount)
        {
            Console.WriteLine("How many lemons do you want to buy? They are " + pricePerLemon + " each.");
            amount = Convert.ToInt32(Console.ReadLine());
            productMath();
        }

        public void productMath(int total, int amount, int price)
        {
            total = amount * price;
            Console.WriteLine("You purchased " + amount + " for a total of " + total);
            Console.ReadLine();
        }
    }
}
