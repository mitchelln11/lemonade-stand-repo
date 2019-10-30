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

        public int remainingLemons;


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
            //recipe.CreateRecipe();
            //lemons = player.recipe.remainingLemons;

            //remainingLemons = lemons.Count - player.recipe.amountOfLemons;
        }

    }
}
