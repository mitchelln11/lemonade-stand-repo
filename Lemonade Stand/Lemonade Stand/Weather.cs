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
        public Random rand;
        public List<string> weatherConditions;
        public int weatherCondition;
        public int tempCondition;

        //constructor
        public Weather()
        {
            rand = new Random();
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Rain", "Partly Cloudy", "Dry", "Humid"};
        }
        
        //member methods (Can Do)
        public string SelectWeather()
        {
            weatherCondition = rand.Next(weatherConditions.Count);
            Console.WriteLine("Weather Condition: " + weatherConditions[weatherCondition]);//Finds string version of index number
            return weatherConditions[weatherCondition];
        }

        public int SelectTemperature()
        {
            tempCondition = rand.Next(56, 103);
            Console.WriteLine("Weather Temperature: " + tempCondition);//Finds string version of index number
            return tempCondition;
        }
    }
}
