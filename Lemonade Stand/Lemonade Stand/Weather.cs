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
        public string condition;
        public int temperature;
        private List<string> weatherConditions;

        //constructor
        public Weather()
        {
            rand = new Random();
            weatherConditions = new List<string>() { "Sunny", "Overcast", "Rain", "Snow", "Sleet", "Humid", "Partly Cloudy" };
            SetRandomCondition();

        }
        

        //member methods (Can Do)
        public void SelectWeather()
        {
            int weatherIndex = rand.Next();
        }

        public void SetRandomCondition()
        {

        }


    }
}
