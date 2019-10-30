using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        //member variables (Has A)
        private Random rand;
        public List<string> weatherConditions;
        public int weatherCondition;
        public List<int> tempReading;
        public int tempCondition;

        //constructor
        public Weather()
        {
            rand = new Random();
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Rain", "Snow", "Sleet", "Humid"};
            tempReading = new List<int>() {65,80,75,90,103,72,86,95,50};
        }
        
        //member methods (Can Do)
        public void SelectWeather()
        {
            weatherCondition = rand.Next(weatherConditions.Count);
            Console.WriteLine("Weather Condition: " + weatherConditions[weatherCondition]);//Finds string version of index number
        }

        public void SelectTemperature()
        {
            tempCondition = rand.Next(tempReading.Count);
            Console.WriteLine("Temperature: " + tempReading[tempCondition]);//Finds string version of index number
        }
    }
}
