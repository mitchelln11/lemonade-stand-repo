using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        //member variables(Has A)

        public string name;
        public List<string> names;

        //constructor (Spawner)
        public Customer()
        {
            names = new List<string>() { "Ralph", "Mike", "Thomas", "Rachel", "Eric", "Michelle", "Nicole", "Maggie", "Katie", "Paige", "Bailey", "Jesus", "Sven" };
        }

        //member methods (Can Do)
        public void PriceFactor(Recipe localRecipe) 
        {
            if (localRecipe.pricePerCup > 5)
            {
                Console.WriteLine("Ja");
                //return true;
            }
            else
            {
                Console.WriteLine("Nein");
                //return false;
            }
        }
    }
}
