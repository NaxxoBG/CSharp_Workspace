using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class TestHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Test();
            Console.ReadKey();
        }

        static void Test()
        {
            Console.WriteLine("Printing from test");
        }
    }
}
