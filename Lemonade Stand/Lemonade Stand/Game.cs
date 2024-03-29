﻿using System;
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
        public int currentDay;

        //constructor (Spawner)
        public Game()
        {
            days = new List<Day>();
            dayMinimum = 7;
            player = new Player();
            day = new Day();
        }

        //member methods (Can Do)
        public void IntroPrompt()
        {
            Console.WriteLine("You are tasked to purchase ingredients for a lemonade stand. \n" +
                "Apply your purchased ingredients to create the right recipe for success. \n" +
                "Weather will be a factor. " +
                "You have 7 days to turn a profit. \n");
            player.AskName();
        }

        public void DaySet()
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
            for (currentDay = 0; currentDay < totalDays; currentDay++)
            {
                day = new Day(); // Needs to be instantiated here, inside loop, otherwise, it resets everytime.
                days.Add(day);
                RunGame();
            }
        }

        public void GameTotals()
        {
            if ( player.wallet.walletTransfers > player.wallet.WalletTotal )
            {
               // player.wallet.MakeWalletCalculation();
                Console.WriteLine("Congratulations, you made " + player.wallet.walletTransfers);
                Console.ReadLine();
            }
            else if(player.wallet.walletTransfers == player.wallet.WalletTotal)
            {
                Console.WriteLine("You broke even.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, you lost money!");
                Console.ReadLine();
            }
        }

        public void EndDayResults(Player player)
        {
            Console.WriteLine("\nEnd of day totals: " + Math.Floor(player.wallet.WalletTotal) + " dollars.");
            Console.WriteLine(day.buyers + " out of " + day.dailyCust + " potential customers. \n");
            player.inventory.UpdateInventory(player, player.wallet); // On here instead of inventory because player is a shared parent.
        }


        public void RunGame()
        {
            Console.WriteLine("Current Day: " + (currentDay + 1));
            Console.WriteLine("Current Wallet Count: " + player.wallet.WalletTotal);
            day.weather.SelectWeather();
            day.weather.SelectTemperature();

            Store store = new Store();
            store.AmountOfLemons(player);
            store.AmountOfSugarCubes(player);
            store.AmountOfIceCubes(player);
            store.AmountOfCups(player);

            player.recipe.CreateRecipe(player.inventory);
            player.recipe.PricePerCup();

            Random rand = new Random();
            day.AddCustomers(rand);
            // Run through each customer in customers list and run the method on the customer class
            foreach (Customer gameCustomer in day.customers)
            {
                gameCustomer.CentMatch();
                bool didBuy = gameCustomer.PriceFactor(player.recipe, player.wallet);
                if (didBuy == true)
                {
                    day.buyers++;
                }
            }
            EndDayResults(player);
        }
    }
}
