using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise7
{
   class Program
   {
      static void Main(string[] args)
      {
         List<double> temps = new List<double>
         {
            1.1,
            1.2,
            1.3,
            12.2,
            22.4,
            32.12,
            33.1,
            43.2,
            88.1,
         };

         foreach (double db in temps)
         {
            if (db >= 25.0)
            {
               Console.WriteLine(db);
            }
         }

         Console.WriteLine( "Count larger than 25 is {0}", GreaterCount(temps, 25.0) );
         #region 3.0
          //OR USING C# 3.0
         List<double> largetemps = temps.FindAll(delegate(double val)
                                                  {
                                                      return val >= 25.0;
                                                  });
         Console.WriteLine("Count larger than 25 is {0}", largetemps.Count());

         #endregion
         Console.ReadKey();
      }

       void test( void )
       {
           int t = 0;
           var tt = t;
           tt++;

           foreach (var item in collection)
	{
		 
	}
       }

      static int GreaterCount<T>(List<T> list, T min) where T : IComparable
      {
         int count = 0;
         foreach ( T t in list )
         {
            if ( t.CompareTo(  min ) > 0 )
            {
               count++;
            }
         }
         return count;
      }
   }
}
