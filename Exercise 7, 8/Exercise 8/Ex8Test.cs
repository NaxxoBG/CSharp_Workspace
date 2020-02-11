using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Ex8Test
    {
        delegate void IntAction(int num);

        static void PrintInt(int number)
        {
            Console.WriteLine(number);
        }

        static void Perform(IntAction act, int[] arr)
        {
            foreach (int num in arr)
            {
                act(num);
            }
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            IntAction del = new IntAction(PrintInt);

            Perform(del, nums);
            Console.ReadKey();
        }
    }
}

