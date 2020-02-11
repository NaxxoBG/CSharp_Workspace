using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Car : IComparable<Car>
    {
        public int EngineSize { get; set; }
        public int TopSpeed { get; set; }
        public int Weight { get; set; }

        public Car(int engineS, int TopS, int W)
        {
            EngineSize = engineS;
            TopSpeed = TopS;
            Weight = W;
        }

        public override string ToString()
        {
            string s = "Engine size=" + EngineSize + " TopSpeed=" + TopSpeed + " Weight=" + Weight;
            return s;
        }


        public int CompareTo(Car other)
        {
            if (other.TopSpeed > TopSpeed)
                return 1;
            else if (other.TopSpeed < TopSpeed)
                return -1;
            else
                return 0;
        }



    }
}
