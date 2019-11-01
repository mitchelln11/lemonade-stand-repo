using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        //member variables(Has A)
        public Weather weather;
        public List<Customer> customers;
        public int dailyCust;
        public Random rand;
        

        //constructor (Spawner)
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            rand = new Random();
        }

        //member methods (Can Do)
        public void AddCustomers(Random randFromGame)
        {
            dailyCust = rand.Next(8, 10);// Must run a random number before the loop
            for (int i = 0; i<dailyCust; i++)
            {
                Customer newCustomer = new Customer(randFromGame);
                customers.Add(newCustomer);
            }
        }
    }
}
