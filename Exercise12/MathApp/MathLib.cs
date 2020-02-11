using System;

namespace MathLibrary
{
    public class MathLib
    {
        public MathLib()
        {

        }

        public double Add(double a, double b) {
            return a + b;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
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
                return Double.NaN;
            } else
            {
                return a / b;
            }
            
        }
        public int Div(int a, int b)
        {
            if (b == 0)
            {
                return int.MinValue;
            }
            else
            {
                return a / b;
            }
        }
    }
}
