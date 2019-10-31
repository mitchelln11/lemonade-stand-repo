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
        public Player player;
        public int currentDay;

        //constructor (Spawner)
        public Game()
        {

        }

        //member methods (Can Do)
        public void runGame()
        {
            Console.WriteLine("You are tasked to purchase ingredients for a lemonade stand. \n" +
                "Apply your purchased ingredients to create the right recipe for success. \n" +
                "Weather will be a factor. " +
                "You have 7 days to turn a profit. \n");

            player = new Player();
            player.askName();

            Day day = new Day();
            day.DaySet();
            day.weather.SelectWeather();
            day.weather.SelectTemperature();

            day.CustomerDecisions(); // Just going here early for testing purposes
            Console.ReadLine();

            Store store = new Store();
            store.AmountOfLemons(player);
            store.AmountOfSugarCubes(player);
            store.AmountOfIceCubes(player);
            store.AmountOfCups(player);

            player.recipe.CreateRecipe(player.inventory);
            player.UpdateInventory(); // On here instead of inventory because player is a shared parent.
            player.FillPitcher();


            Console.ReadLine();

            //Day day = new Day("Tuesday");
            //days.Add(day);
            //Weather weather = new Weather();
            //weather.temperature();
        }
    }
}
