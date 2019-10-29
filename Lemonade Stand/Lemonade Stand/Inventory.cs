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
        public int lemonInventory;


        //constructor (Spawner)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }


        //member methods (Can Do)
        public void CreateInventory()
        {
            if (lemons.Count != 0)
            {
                Console.WriteLine("Lemons: " + lemons.Count);
            }
            if (sugarCubes.Count != 0)
            {
                Console.WriteLine("Sugar Cubes: " + sugarCubes.Count);
            }
            if (iceCubes.Count != 0)
            {
                Console.WriteLine("Ice Cubes: " + iceCubes.Count);
            }
            if (cups.Count != 0)
            {
                Console.WriteLine("Cups: " + cups.Count);
            }
        }
        

    }
}
