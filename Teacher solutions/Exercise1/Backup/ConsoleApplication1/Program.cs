using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Exercise1
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Assignment 1.1 -----");
            for (int i = 100; i <= 202; i += 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n--------------------------");
            
            Console.WriteLine("----- Assignment 1.2 -----");
            for ( int i = 202; i >= 100; i -= 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n--------------------------");

            Console.WriteLine("----- Assignment 1.3a -----");
            int t = 100;
            while( t <= 202 )
            {
                Console.Write("{0} ", t++ );
            }
            Console.WriteLine("\n--------------------------");

            Console.WriteLine("----- Assignment 1.3b -----");
            t = 100;
            while( t <= 202 )
            {
                switch( t )
                {
                    case 110:
                    case 130:
                    case 140:
                        Console.WriteLine("This is a funny number");
                        break;
                    case 122:
                        Console.WriteLine("this is my lucky number");
                        break;
                    case 198:
                        break;
                    default:
                        Console.WriteLine("{0} ", t);
                        break;
                }
                t++;
            }
            Console.WriteLine("\n--------------------------");

            Console.WriteLine("----- Assignment 1.4 -----");
            for (int i = 1; i <= 255; i++ )
            {
                Console.Write("{0:X2} ", i );
                if (i % 16 == 0)
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("\n--------------------------");

            Console.ReadKey();
        }
    }
}
