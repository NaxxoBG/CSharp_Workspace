using System;
using System.Collections.Generic;
using System.Text;

namespace INET
{
    public class MathLib
    {
        public int Add(int n1, int n2)
        {
            return (n1 + n2);
        }
        public int Sub(int n1, int n2)
        {
            return (n1 - n2);
        }

      public int Div(int a, int b)
      {
         if (b == 0)
         {
            throw new Exception("Hey");
            // throw new DivideByZeroException("Hey dude");
         }

         return a / b;
      }
    }
}
