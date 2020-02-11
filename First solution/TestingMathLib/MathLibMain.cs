using System;
using MathLibrary;

namespace TestingMathLib
{
    class MathLibMain
    {
        static void Main(string[] args)
        {
            #region reg1
            MathLib math = new MathLib();
            Console.WriteLine(math.Add(10, 4));
            Console.ReadLine();
            #endregion
        }
    }
}