﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        //member variables(Has A)
        public string name;
        public List<string> names;
        public Random rand;
        public double centCap;

        //constructor (Spawner)
        public Customer()
        {
            rand = new Random();
            names = new List<string>() { "Ralph", "Mike", "Thomas", "Rachel", "Eric", "Michelle", "Nicole", "Maggie", "Katie", "Paige", "Bailey", "Jesus", "Sven" };
        }

        //member methods (Can Do)

        private double CentMatch()
        {
            centCap = rand.Next(25, 99);
            Console.WriteLine(centCap);//Finds string version of index number
            return centCap;
        }

        public void PriceFactor(Recipe localRecipe) 
        {
            CentMatch();
            if (localRecipe.pricePerCup > centCap) //Need random cent amount to match against
            {
                Console.WriteLine(localRecipe.pricePerCup + " Ja");
                //return true;
            }
            else
            {
                Console.WriteLine(centCap + " Nein");
                //return false;
            }
        }
    }
}
