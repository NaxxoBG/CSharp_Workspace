using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Ex7Test
    {
        public List<double> Temps { get; set; }
        private Random rand;
        public double RandomNum => Math.Round(1 + (rand.NextDouble() * (40 - 1)), 2);
        

        public Ex7Test()
        {
            Temps = new List<double>();
            rand = new Random();
        }

        static Tuple<List<T>, int> GreaterCount<T>(List<T> list, T min) where T : IComparable
        {
            List<T> res = list.FindAll(e => e.CompareTo(min) > 0).ToList();
            return Tuple.Create(res, res.Count);
        }

        public void PrintList<T>(List<T> list)
        {
            list.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Ex7Test prog = new Ex7Test();
            for (int i = 0; i < 10; i++)
            {
                prog.Temps.Add(prog.RandomNum);
            }
            
            prog.PrintList<double>(prog.Temps);

            List<double> greater = GreaterCount<double>(prog.Temps, 25).Item1;

            prog.PrintList<double>(greater);
            Console.ReadLine();
        }
    }
}
