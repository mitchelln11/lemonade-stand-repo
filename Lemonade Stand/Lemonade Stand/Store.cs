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
        private int lemonAmountPrompt;
        public double lemonTotal;

        //constructor (Spawner)
        public Store()
        {
            pricePerLemon = 0.20;
            pricePerSugarCube = 0.10;
            pricePerIceCube = 0.02;
            pricePerCup = 0.05;
        }

        //member methods (Can Do)
        public void AmountOfLemons()
        {
            Player player = new Player();
            player.askName();
            Console.WriteLine("How many lemons do you want to buy " + player.name + "? They are " + pricePerLemon + " each.");
            lemonAmountPrompt = Convert.ToInt32(Console.ReadLine());
            LemonMath();
        }

        public void LemonMath()
        {
            lemonTotal = lemonAmountPrompt * pricePerLemon;
            Console.WriteLine(lemonTotal);
            Console.ReadLine();
        }
    }
}
