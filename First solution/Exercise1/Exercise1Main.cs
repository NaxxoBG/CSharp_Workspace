using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Exercise1Main
    {
        static void Main(string[] args)
        {
            CLBirdie bird = new CLBirdie();
            bird.MakeSomeNoise();
            PrintEverySecondNumber();
            Console.ReadKey();
            PrintEverySecondInReverse();
            Console.ReadKey();
            PrintFunnyNums();
            Console.ReadKey();
            PrintDecimalToHex();
            Console.ReadKey();
        }

        static void PrintEverySecondNumber()
        {
            for (int i = 0; i <= 202; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void PrintEverySecondInReverse()
        {
            for (int i = 202; i >= 100; i-=2)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintFunnyNums()
        {
            for (int i = 100; i <= 202; i+=2) {
                switch (i) {
                    case 110:
                    case 130:
                    case 140:
                        Console.WriteLine("This is a funny number");
                        break;
                    case 122:
                        Console.WriteLine("This is my lucky number");
                        break;
                    case 198:
                        continue;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }

        static void PrintDecimalToHex()
        {
            for (int i = 1; i <= 255; i++)
            {
                string res = Convert.ToString(i, 16).ToUpper();
                if (res.Length == 1)
                {
                    Console.WriteLine(string.Concat("0", res));
                } else {
                    Console.WriteLine(res);
                }
                
            }
        }
    }
}