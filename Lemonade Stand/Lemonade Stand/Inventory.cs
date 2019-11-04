using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        //member variables(Has A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        public int updatedLemonTotal;
        public int updatedSugarTotal;
        public int updatedIceTotal;

        //constructor (Spawner)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }



        //member methods (Can Do)
        public void AddLemonsInv(Player player, double lemonAmountPrompt)
        {
            for (int i = 0; i < lemonAmountPrompt; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.lemons.Add(lemon);
            }

        }

        public void AddSugarCubeInv(Player player, double sugarCubeAmountPrompt)
        {
            for (int i = 0; i < sugarCubeAmountPrompt; i++)
            {
                SugarCube sugarCube = new SugarCube();
                player.inventory.sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubeInv(Player player, double iceCubeAmountPrompt)
        {
            for (int i = 0; i < iceCubeAmountPrompt; i++)
            {
                IceCube iceCube = new IceCube();
                player.inventory.iceCubes.Add(iceCube);
            }
        }

        public void AddCupInv(Player player, double cupAmountPrompt)
        {
            for (int i = 0; i < cupAmountPrompt; i++)
            {
                Cup cups = new Cup();
                player.inventory.cups.Add(cups);
            }
        }

        public void UpdateInventory(Player player, Wallet wallet)
        {
            updatedLemonTotal = lemons.Count - player.recipe.amountOfLemons;
            updatedSugarTotal = sugarCubes.Count - player.recipe.amountOfSugarCubes;
            updatedIceTotal = iceCubes.Count - iceCubes.Count;
            Console.WriteLine(updatedLemonTotal + " lemons remaining");
            Console.WriteLine(updatedSugarTotal + " Sugar Cubes remaining");
            Console.WriteLine("Remaining Ice has melted.");
            player.wallet.MakeWalletCalculation();
            Console.WriteLine("Your totals for the day: " + wallet.walletTransfers + " dollars. Press enter to continue.");
        }
    }
}
