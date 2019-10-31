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
        public int totalDays;
        public List<Day> days;
        private int dayMinimum;
        public List<string> names;
        public List<Customer> customers;

        //constructor (Spawner)
        public Day()
        {
            //dayOfWeek = dayName;
            days = new List<Day>();
            customers = new List<Customer>();
            dayMinimum = 7;
            weather = new Weather();
            names = new List<string>() { "Ralph", "Mike", "Thomas", "Rachel", "Eric", "Michelle", "Nicole", "Maggie", "Katie", "Paige", "Bailey", "Jesus", "Sven" };
        }

        //member methods (Can Do)
        public void DaySet()
        {
            Console.WriteLine("How many days do you want to play for? You must play for at least 7 days.");
            totalDays = Convert.ToInt32(Console.ReadLine());

            if (totalDays >= dayMinimum)
            {
                for (int currentDay = 0; currentDay < totalDays; currentDay++)
                {
                    Day day = new Day();
                    days.Add(day);
                    // Add weather
                    // Shop at store
                    // Run a day
                }
            }
            else
            {
                Console.WriteLine("Sorry, you must play at least 7 days.");
                DaySet();
            }
        }

        public void CustomerDecisions()
        {
            Console.WriteLine(weather.tempCondition);

            if (weather.tempCondition < 95)
            {
                Customer newCustomer = new Customer();
                customers.Add(newCustomer);
                customers.Add(newCustomer);
                customers.Add(newCustomer);
            }
            else
            {
                Console.WriteLine("below the test");
            }
        }

        public void PriceFactor(Recipe localRecipe)
        {
            if (localRecipe.pricePerCup > 5)
            {
                Console.WriteLine("Ja");
                //return true;
            }
            else
            {
                Console.WriteLine("Nein");
                //return false;
            }
        }

    }
}
