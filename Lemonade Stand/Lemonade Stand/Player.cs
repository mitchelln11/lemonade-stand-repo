﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        //member variables (Has A)
        public string name;
        public Wallet wallet;
        public Inventory inventory;
        public Recipe recipe;
        public Pitcher pitcher;

        public int updatedLemonTotal;
        public int updatedSugarTotal;
        public int updatedIceTotal;
        public int pitcherAmount;

        //constructor (Spawner)
        public Player()
        {
            wallet = new Wallet();//Player owns wallet
            inventory = new Inventory();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        //member methods (Can Do)
        public void AskName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine().Replace(" ", "").Trim();
        }

        public void UpdateInventory()
        {
            updatedLemonTotal = inventory.lemons.Count - recipe.amountOfLemons;
            updatedSugarTotal = inventory.sugarCubes.Count - recipe.amountOfSugarCubes;
            updatedIceTotal = inventory.iceCubes.Count - inventory.iceCubes.Count;
            Console.WriteLine(updatedLemonTotal + " lemons remaining");
            Console.WriteLine(updatedSugarTotal + " Sugar Cubes remaining");
            Console.WriteLine("Remaining Ice has melted. Press enter to continue");
        }
    }
}
