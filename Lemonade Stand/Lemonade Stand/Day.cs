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
        //public List<Customer> customers;
        public string dayOfWeek;

        //constructor (Spawner)
        public Day(string dayName)
        {
            dayOfWeek = dayName;
            weather = new Weather();
        }

        //member methods (Can Do)
    }
}
