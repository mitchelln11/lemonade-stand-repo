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
        public double custRandomCap;
        public Random rand;
        public double centCap;

        //constructor (Spawner)
        public Day()
        {
            //dayOfWeek = dayName;
            //days = new List<Day>();
            customers = new List<Customer>();
            //dayMinimum = 7;
            weather = new Weather();
            rand = new Random();
            //names = new List<string>() { "Ralph", "Mike", "Thomas", "Rachel", "Eric", "Michelle", "Nicole", "Maggie", "Katie", "Paige", "Bailey", "Jesus", "Sven" };
        }

        //member methods (Can Do)
        public double CentMatch()
        {
            centCap = rand.Next(20, 99);
            return centCap;
        }

        public void CustomerDecisions()
        {
            Console.WriteLine(weather.tempCondition);

            for (int i = 0; i<6; i++)
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
