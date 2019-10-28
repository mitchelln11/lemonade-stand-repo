using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        //member variables (Has A)
        Player player;
        private List<Day> days;
        public int currentDay;

        //constructor (Spawner)
        

        //member methods (Can Do)
        public void runGame()
        {
            player = new Player();

            Store store = new Store();
            store.AmountOfLemons();

            days = new List<Day>();
            Day day = new Day("Monday");
            days.Add(day);
            //Weather weather = new Weather();
            //weather.temperature();
        }
    }
}
