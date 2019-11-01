using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        //member variables(Has A)
        public Random rand;
        public double centCap;

        //constructor (Spawner)
        public Customer(Random randFromGame)
        {
            rand = randFromGame;
        }

        //member methods (Can Do)
        public double CentMatch()
        {
            centCap = rand.Next(20, 99);
            centCap = (centCap / 100); //Convert amount to cents
            return centCap;
        }


        public void PriceFactor(Recipe localRecipe, Wallet wallet)
        {
            if (localRecipe.pricePerCup < centCap)
            {
                wallet.WalletTotal += wallet.WalletTotal + localRecipe.pricePerCup;
                Console.WriteLine(centCap + " Purchased!");
            }
            else
            {
                Console.WriteLine(centCap + " Nein");
            }
            Console.WriteLine(wallet.WalletTotal);
        }
    }
}
