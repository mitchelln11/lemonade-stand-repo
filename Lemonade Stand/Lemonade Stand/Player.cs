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
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;


        //constructor (Spawner)
        public Player()
        {
            wallet = new Wallet();//Player owns wallet
            inventory = new Inventory();
        }

        //member methods (Can Do)
        public void askName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine().Replace(" ", "").Trim();
        }
    }
}
