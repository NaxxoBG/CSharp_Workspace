using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8Org
{
    class Program
    {
        delegate void IntAction( int WhatEver );

        static void Main(string[] args)
        {
            // Question a
            IntAction act = PrintInt;
            act( 42 );

            //question b
            int[] listOfInt = {1,2,3,4,5,6,7,8,9};
            Perform( act, listOfInt);

            //Console.WriteLine("Another approach ");
            Perform( act, 11, 12, 13, 14, 15, 16, 17, 18, 20, 22, 12);


            Console.ReadKey();
        }

        static void PrintInt( int n )
        {
            Console.WriteLine( "Printing an integer = {0}", n );
        }

        static void Perform(IntAction act, params int[] arr)
        {
            foreach (int item in arr)
            {
                act(item);
            }
        }
        static void Perform1(IntAction act, params int[] arr)
        {
            foreach (int item in arr)
            {
                act(item);
            }
        }
    }
}
