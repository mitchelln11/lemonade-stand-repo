using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        //member variables(Has A)
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        //constructor (Spawner)
        public Store()
        {
            pricePerLemon = 0.20;
            pricePerSugarCube = 0.10;
            pricePerIceCube = 0.02;
            pricePerCup = 0.05;
        }

        // DON'T FORGET TO ADD CONDITIONAL IF THERE ISN'T ENOUGH MONEY IN THE WALLET

        //member methods (Can Do)
        // --------------------------------Lemon Section------------------------------------------------
        public void AmountOfLemons(Player player)
        {
            int lemonAmountPrompt;
            double lemonTotal;

            Console.WriteLine("How many lemons do you want to buy " + player.name + "? They are " + pricePerLemon + " each.");
            lemonAmountPrompt = Convert.ToInt32(Console.ReadLine());
            lemonTotal = LemonMath(lemonAmountPrompt);

            if (player.wallet.WalletTotal >= lemonAmountPrompt)
            {
                Console.WriteLine(player.name + ", you purchased " + lemonAmountPrompt + " lemons for " + lemonTotal + " dollars");
            }
            else
            {
                Console.WriteLine("I'm sorry, you don't have enough funds for that much");
            }
            
            player.wallet.WalletTotal = player.wallet.WalletTotal - lemonTotal;
            Console.WriteLine(player.wallet.WalletTotal + " dollars remaining \n");
            player.inventory.AddLemonsInv(player, lemonAmountPrompt);
        }

        public double LemonMath(int lemonAmount)
        {
            double lemonTotal = lemonAmount * pricePerLemon;
            return lemonTotal;
        }

        // --------------------------------Sugar Cubes Section------------------------------------------------
        public void AmountOfSugarCubes(Player player)
        {
            int sugarCubeAmountPrompt;
            double sugarCubeTotal;

            Console.WriteLine("How many sugar cubes do you want to buy " + player.name + "? They are " + pricePerSugarCube + " each.");
            sugarCubeAmountPrompt = Convert.ToInt32(Console.ReadLine());
            sugarCubeTotal = SugarCubeMath(sugarCubeAmountPrompt);
            Console.WriteLine(player.name + ", you purchased " + sugarCubeAmountPrompt + " sugar cubes for " + sugarCubeTotal + " dollars");
            player.wallet.WalletTotal = player.wallet.WalletTotal - sugarCubeTotal;
            Console.WriteLine(player.wallet.WalletTotal + " dollars remaining \n");
            player.inventory.AddSugarCubeInv(player, sugarCubeAmountPrompt);
        }

        public double SugarCubeMath(int sugarCubeAmount)
        {
            double sugarCubeTotal = sugarCubeAmount * pricePerSugarCube;
            return sugarCubeTotal;
        }

        

        // --------------------------------Ice Cubes Section------------------------------------------------
        public void AmountOfIceCubes(Player player)
        {
            int iceCubeAmountPrompt;
            double iceCubeTotal;

            Console.WriteLine("How many ice cubes do you want to buy " + player.name + "? They are " + pricePerIceCube + " each.");
            iceCubeAmountPrompt = Convert.ToInt32(Console.ReadLine());
            iceCubeTotal = IceCubeMath(iceCubeAmountPrompt);
            Console.WriteLine(player.name + ", you purchased " + iceCubeAmountPrompt + " ice cubes for " + iceCubeTotal + " dollars");
            player.wallet.WalletTotal = player.wallet.WalletTotal - iceCubeTotal;
            Console.WriteLine(player.wallet.WalletTotal + " dollars remaining \n");
            player.inventory.AddIceCubeInv(player, iceCubeAmountPrompt);
        }

        public double IceCubeMath(int iceCubeAmount)
        {
            double iceCubeTotal = iceCubeAmount * pricePerIceCube;
            return iceCubeTotal;
        }

        // --------------------------------Cups Section------------------------------------------------
        public void AmountOfCups(Player player)
        {
            int cupAmountPrompt;
            double cupTotal;

            Console.WriteLine("How many cups do you want to buy " + player.name + "? They are " + pricePerCup + " each.");
            cupAmountPrompt = Convert.ToInt32(Console.ReadLine());
            cupTotal = CupMath(cupAmountPrompt);
            Console.WriteLine(player.name + ", you purchased " + cupAmountPrompt + " cups for " + cupTotal + " dollars");
            player.wallet.WalletTotal = player.wallet.WalletTotal - cupTotal;
            Console.WriteLine(player.wallet.WalletTotal + " dollars remaining \n");
            player.inventory.AddCupInv(player, cupAmountPrompt);
        }

        public double CupMath(int cupAmount)
        {
            double cupTotal = cupAmount * pricePerCup;
            return cupTotal;
        }
    }
}
