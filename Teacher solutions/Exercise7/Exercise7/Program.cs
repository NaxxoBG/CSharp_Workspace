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


         #region GENERIC
         List<int> ti = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         GreaterCount<int>( ti, 2);
         #endregion



         #region delegate
         List<double> largetemps = temps.FindAll(GreaterThan);
         Console.WriteLine("Count larger than 25 is {0}", largetemps.Count());
         #endregion
         
         #region anonymous
         List<double> largetemps1 = temps.FindAll(delegate(double val)
                                                  {
                                                     return val >= 25.0;
                                                  });
         Console.WriteLine("Count larger than 25 is {0}", largetemps1.Count());

         #endregion
         #region lambda
         List<double> largetemps2 = temps.FindAll(d => d >= 25.0);
         Console.WriteLine("Count larger than 25 is {0}", largetemps2.Count());

         #endregion
         Console.ReadKey();
      }
      
       static int GreaterCount( List<double> list, double min ) 
       {
           int count = 0;
           foreach (double t in list)
           {
               if ( t > min )
               {
                   count++;
               }
           }
           return count;
       
       }

      static int GreaterCount<T>(List<T> list, T min) where T : IComparable
      {
         int count = 0;
         foreach ( T t in list )
         {
            if ( t.CompareTo( min ) > 0 )
            {
               count++;
            }
         }
         return count;
      }

      static bool GreaterThan(double val )
      {
         return val > 25;
      }
   }
}
