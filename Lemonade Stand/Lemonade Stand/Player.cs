using System;
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


        //constructor (Spawner)
        public Player()
        {
            wallet = new Wallet();//Player owns wallet
            inventory = new Inventory();
            recipe = new Recipe();
        }

        //member methods (Can Do)
        public void askName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine().Replace(" ", "").Trim();
        }
    }
}
