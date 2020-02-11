using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise8
{
   public delegate void Action<T>(T t);
   class Test
   {
      public static void Perform<T>( Action<T> act, params T[] arr )
      {
         foreach( T t in arr )
         {
            act( t );
         }
      }
   }
   
   class Program
   {
      static void Main( string[] args )
      {
         int[] xs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 22, 25, 26, 27, 28, 29, 30 };

         Test test = new Test();
         Console.WriteLine("Printing even numbers");
         
         Test.Perform( MyAction, xs );

         Test.Perform(MyAction, 1,2,3,4,5,6,7,8,9,0);


         Console.WriteLine( "Another action" );
         Test.Perform(MyAnotherAction, xs);


         #region questionB
         //// Or with an anonym 
         Console.WriteLine("Printing even numbers with ano");
         Test.Perform<int>(delegate(int x)
                            {
                                if (x % 2 == 0)
                                {
                                    Console.WriteLine(x + " ");
                                }
                            },
                            xs);
         
         #endregion
         
         #region questionC
         //// Or with a lambda
         //Console.WriteLine("Printing even numbers with lambda");
         //Test.Perform<int>(x => 
         //                  { 
         //                     if (x % 2 == 0)
         //                        Console.WriteLine(x);
         //                  }, xs);


         //Test.Perform<int>( x => Console.WriteLine(x), xs );
         
         #endregion

         Console.ReadKey();
      }

      static void MyAction(int x)
      {
         if( x % 2 == 0 )
         {
            Console.WriteLine(x + " ");
         }
      }

      static void MyAnotherAction(int x)
      {
          if (x % 2 != 0)
          {
              Console.WriteLine(x + " ");
          }
      }
   }
}
