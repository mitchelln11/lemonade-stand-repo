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
        private Player player;
        public Day day;
        private List<Day> days;
        private int totalDays;
        private int dayMinimum;
        public Recipe localRecipe;
        public int currentDay;
        public double lemonadePrice;

        //constructor (Spawner)
        public Game()
        {
            days = new List<Day>();
            dayMinimum = 7;
            player = new Player();
        }

        //member methods (Can Do)

        private void DaySet()
        {
            Console.WriteLine("How many days do you want to play for? You must play for at least 7 days.");
            int potentialdays = Convert.ToInt32(Console.ReadLine());

            if (potentialdays >= dayMinimum)
            {
                totalDays = potentialdays;
            }
            else
            {
                Console.WriteLine("Sorry, you must play at least 7 days.");
                DaySet();
            }
        }

        public void IncrementDay()
        {
            for (currentDay = 1; currentDay < totalDays; currentDay++)
            {
                Day day = new Day();
                days.Add(day);
            }
            RunGame();
        }


        public void IntroPrompt()
        {
            Console.WriteLine("You are tasked to purchase ingredients for a lemonade stand. \n" +
                "Apply your purchased ingredients to create the right recipe for success. \n" +
                "Weather will be a factor. " +
                "You have 7 days to turn a profit. \n");
                player.AskName();
        }

        public void RunGame()
        {
            day = new Day();
            DaySet();
            Console.WriteLine("Current Day: " + currentDay);
            day.weather.SelectWeather();
            day.weather.SelectTemperature();

            //day.CustomerDecisions(); // Just going here early for testing purposes

            Store store = new Store();
            store.AmountOfLemons(player);
            store.AmountOfSugarCubes(player);
            store.AmountOfIceCubes(player);
            store.AmountOfCups(player);

            player.recipe.CreateRecipe(player.inventory);
            player.recipe.PricePerCup();
            

            day.AddCustomers();
            // Run through each customer in customers list and run the method on the customer class
            foreach (Customer gameCustomer in day.customers)
            {
                day.CentMatch();
                day.PriceFactor(player.recipe);
            }
            
            player.UpdateInventory(); // On here instead of inventory because player is a shared parent.
            player.FillPitcher();

            Console.ReadLine();
        }
    }
}
