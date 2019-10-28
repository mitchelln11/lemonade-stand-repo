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
        private int lemonAmountPrompt;
        public double lemonTotal;

        private double pricePerSugarCube;
        private int sugarCubeAmountPrompt;
        public double sugarCubeTotal;

        private double pricePerIceCube;
        private int iceCubeAmountPrompt;
        public double iceCubeTotal;

        private double pricePerCup;
        private int cupAmountPrompt;
        public double cupTotal;

        Player player = new Player();
        

        //constructor (Spawner)
        public Store()
        {
            pricePerLemon = 0.20;
            pricePerSugarCube = 0.10;
            pricePerIceCube = 0.02;
            pricePerCup = 0.05;
            player.askName();
        }

        //member methods (Can Do)
        // --------------------------------Lemon Section------------------------------------------------
        public void AmountOfLemons()
        {
            Console.WriteLine("How many lemons do you want to buy " + player.name + "? They are " + pricePerLemon + " each.");
            lemonAmountPrompt = Convert.ToInt32(Console.ReadLine());
            LemonMath();
            Console.WriteLine(player.name + ", you purchased " + lemonAmountPrompt + " lemons for " + lemonTotal);
        }

        public void LemonMath()
        {
            lemonTotal = lemonAmountPrompt * pricePerLemon;
            Console.WriteLine(lemonTotal);
            
        }

        // --------------------------------Sugar Cubes Section------------------------------------------------
        public void AmountOfSugarCubes()
        {
            Console.WriteLine("How many sugar cubes do you want to buy " + player.name + "? They are " + pricePerSugarCube + " each.");
            sugarCubeAmountPrompt = Convert.ToInt32(Console.ReadLine());
            SugarCubeMath();
            Console.WriteLine(player.name + ", you purchased " + sugarCubeAmountPrompt + " sugar cubes for " + sugarCubeTotal);
        }

        public void SugarCubeMath()
        {
            sugarCubeTotal = sugarCubeAmountPrompt * pricePerSugarCube;
            Console.WriteLine(sugarCubeTotal);
        }

        // --------------------------------Ice Cubes Section------------------------------------------------
        public void AmountOfIceCubes()
        {
            Console.WriteLine("How many ice cubes do you want to buy " + player.name + "? They are " + pricePerIceCube + " each.");
            iceCubeAmountPrompt = Convert.ToInt32(Console.ReadLine());
            IceCubeMath();
            Console.WriteLine(player.name + ", you purchased " + iceCubeAmountPrompt + " ice cubes for " + iceCubeTotal);
        }

        public void IceCubeMath()
        {
            iceCubeTotal = iceCubeAmountPrompt * pricePerIceCube;
            Console.WriteLine(iceCubeTotal);
        }

        // --------------------------------Cups Section------------------------------------------------
        public void AmountOfCups()
        {
            Console.WriteLine("How many cups do you want to buy " + player.name + "? They are " + pricePerCup + " each.");
            cupAmountPrompt = Convert.ToInt32(Console.ReadLine());
            CupMath();
            Console.WriteLine(player.name + ", you purchased " + cupAmountPrompt + " cups for " + cupTotal);
        }

        public void CupMath()
        {
            cupTotal = cupAmountPrompt * pricePerCup;
            Console.WriteLine(cupTotal);
        }
    }
}
