using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaxable house = new House(0.3, "Cal", true, 500000);
            ITaxable bus = new Bus(100, 4552, 4, 100000);

            bus.TaxValue();
            house.TaxValue();
        }
    }
}