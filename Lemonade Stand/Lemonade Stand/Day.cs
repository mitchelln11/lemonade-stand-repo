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
        public Weather weather;
        public int totalDays;
        public List<Day> days;
        private int dayMinimum;

        //public List<Customer> customers;
        public string dayOfWeek;

        //constructor (Spawner)
        public Day()
        {
            //dayOfWeek = dayName;

            days = new List<Day>();
            dayMinimum = 7;
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
                    // Update inventory
                    // Create recipe
                    // Run a day
                }
            }
            else
            {
                Console.WriteLine("Sorry, you must play at least 7 days.");
                DaySet();
            }
        }

        public void SelectWeather()
        {

        }
    }
}
