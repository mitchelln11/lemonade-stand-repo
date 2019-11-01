using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        //member variables(Has A)
        public List<string> weatherConditions;
        public Weather weather;
        //public List<Day> days;
        //private int dayMinimum;
        public List<string> names;
        public List<Customer> customers;
        public int dailyCust;
        public Random rand;
        public double centCap;

        //constructor (Spawner)
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            rand = new Random();
        }

        //member methods (Can Do)
        public double CentMatch()
        {
            centCap = rand.Next(20, 99);
            return centCap;
        }


        public void CustomerDecisions()
        {
            //Instead of creating a method to generate a random number, just generate inside the spot where it's needed
            for (int i = 0; i< rand.Next(50, 150); i++)
            {
                Customer newCustomer = new Customer();
                customers.Add(newCustomer);
            }
        }

        public void PriceFactor(Recipe localRecipe)
        {
            if (localRecipe.pricePerCup < centCap)
            {
                Console.WriteLine(centCap + " Ja");
                //return true;  ? Why can't I return? Even when it's not void
            }
            else
            {
                Console.WriteLine(centCap + " Nein");
                //return false; ? Why can't I return? Even when it's not void
            }
        }

    }
}
