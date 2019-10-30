using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        //member variables (Has A)
        public Player player;
        private List<Day> days;
        public int currentDay;

        //constructor (Spawner)
        

        //member methods (Can Do)
        public void runGame()
        {
            Console.WriteLine("You are tasked to purchase ingredients for a lemonade stand. \n" +
                "Apply your purchased ingredients to create the right recipe for success. \n" +
                "Weather will be a factor. " +
                "You have 7 days to turn a profit. \n");

            player = new Player();
            player.askName();

            Store store = new Store();
            store.AmountOfLemons(player);
            store.AmountOfSugarCubes(player);
            store.AmountOfIceCubes(player);
            store.AmountOfCups(player);

            //player.inventory.CreateInventory();
            player.recipe.CreateRecipe(player.inventory);
            player.inventory.CreateInventory();

            player.UpdateInventory();


            Console.ReadLine();

            
            //Day day = new Day("Monday");
            //days.Add(day);
            //Weather weather = new Weather();
            //weather.temperature();
        }
    }
}
