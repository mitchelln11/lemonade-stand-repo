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
        public Customer customer;
        public int buyers;


        //constructor (Spawner)
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            rand = new Random();
        }

        //member methods (Can Do)
        public int AddCustomers(Random randFromGame)
        {
            if ((weather.tempCondition >= 95) && (weather.tempCondition < 105) )
            {
                dailyCust = rand.Next(50, 125);// Must run a random number before the loop
            }
            else if ( (weather.tempCondition >= 80) && (weather.tempCondition <= 94) )
            {
                dailyCust = rand.Next(115, 150);
            }
            else if ((weather.tempCondition >= 70) && (weather.tempCondition <= 79))
            {
                dailyCust = rand.Next(95, 145);
            }
            else if (weather.tempCondition <= 69)
            {
                dailyCust = rand.Next(45, 60);
            }
            for (int i = 0; i<dailyCust; i++)
            {
                Customer newCustomer = new Customer(randFromGame);
                customers.Add(newCustomer);
            }
            return dailyCust;
        }
    }
}
