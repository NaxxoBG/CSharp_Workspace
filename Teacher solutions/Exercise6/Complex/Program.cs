using System;
using System.Collections.Generic;
using System.Text;

namespace Complex
{
   class Program
   {
      static void Main(string[] args)
      {
         Complex x = 1;
         Complex y = new Complex(2, 1);
         Console.WriteLine( "x={0}  y={1}", x, y );
         Console.WriteLine( "x + y = {0}", x + y);
         Console.WriteLine( "x - y = {0}", x - y);
         Console.WriteLine( "x * y = {0}", x * y);
         Console.WriteLine( "x / y = {0}", y / y);

         Console.WriteLine("explicit cast: x as double = {0}", (double)x);
         Console.WriteLine("explicit cast: y as double = {0}", (double)y);


         Complex x1 = 12.122;
         Console.WriteLine("implicit cast from double to Complex x1 = {0}", x1);

         Complex y1 = 33;
         Console.WriteLine("implicit cast from double to Complex y1 = {0}", y1);
         
        Console.ReadKey();
      }
   }
}
