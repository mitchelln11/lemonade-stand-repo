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
        public List<Day> day;
        private Random rand;
        public string condition;
        // public int temperature;
        public List<string> weatherConditions;
        public int weatherIndex;
        public int weatherConditionCount;

        //constructor
        public Weather()
        {
            rand = new Random();
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Rain", "Snow", "Sleet", "Humid"};
        }
        
        //member methods (Can Do)
        public void SelectWeather()
        {
            weatherIndex = rand.Next(weatherConditions.Count);
            Console.WriteLine(weatherConditions.Count + " Weather Index " + weatherConditions[weatherIndex]);
        }

        //public void SetRandomCondition()
        //{

        //}


    }
}
