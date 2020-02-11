using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();

            list.Add(new Car(10, 200, 30));
            list.Add(new Car(10, 260, 30));
            list.Add(new Car(10, 250, 30));
            list.Add(new Car(10, 200, 30));
            list.Add(new Car(10, 190, 30));
            list.Add(new Car(10, 180, 30));


            foreach (Car car in list)
            {
                Console.WriteLine( car );
            }

            list.Sort();

            Console.WriteLine( "Sorted");


            foreach (Car car in list)
            {
                Console.WriteLine(car);
            }

            
            Console.ReadKey();
        }
    }
}
