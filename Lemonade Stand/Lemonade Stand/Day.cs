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

        public void AddCustomers()
        {
            dailyCust = rand.Next(8, 10);// Must run a random number before the loop
            for (int i = 0; i<dailyCust; i++)
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
