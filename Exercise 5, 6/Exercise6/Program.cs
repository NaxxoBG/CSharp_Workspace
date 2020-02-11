using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car(rnd.Next(1600, 5000), rnd.Next(700, 1500), rnd.Next(160, 250)));
            }

            PrintList(cars);

            Console.WriteLine("Sort by top speed");
            cars = cars.OrderByDescending(o => o.TopSpeed).ToList();
            PrintList(cars);

            Console.WriteLine("Sort by engine size");
            cars = cars.OrderBy(o => o.EngineSize).Reverse().ToList();
            PrintList(cars);

            Console.WriteLine("Sort by Top Speed again");
            cars.Sort();
            PrintList(cars);
        }

        public static void PrintList(List<Car> list)
        {
            list.ForEach(new Action<Car>(Console.WriteLine));
            Console.ReadLine();
        }
    }
}