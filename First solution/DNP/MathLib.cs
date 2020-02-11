using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathLib
    {
        public int Add(int a, int b) {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b) {
            return a * b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Cannot divide by zero");
            } else
            {
                return a / b;
            }
            
        }
        public int Div(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Cannot divide by zero");
            }
            else
            {
                return a / b;
            }
        }
    }
}
