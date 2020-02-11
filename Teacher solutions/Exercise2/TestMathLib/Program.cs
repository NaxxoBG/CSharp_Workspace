using System;
using System.Collections.Generic;
using System.Text;
using INET;

namespace TestMathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            INET.MathLib math = new MathLib();

         try
         {
            math.Div(2, 0);
         }
         catch (Exception c)
         {
            Console.WriteLine( c.Message );

         }
 


            System.Console.WriteLine("Add 4 to 5 equals {0}", math.Add(4, 5));
            System.Console.WriteLine("Sub 4 from 5 equals {0}", math.Sub(4, 5));
            System.Console.ReadKey();
        }
    }
}