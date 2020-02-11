using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Car : IComparable<Car>
    {
        public int EngineSize { get; }
        public double Weight { get; }
        public int TopSpeed { get; }


        public Car(int engSize, int weight, int topSpeed)
        {
            if (engSize < 1600 || engSize > 5000)
            {
                throw new ArgumentOutOfRangeException("Engine size should be between 1600 and 5000");
            }
            else
            {
                this.EngineSize = engSize;
            }

            this.Weight = weight;

            if (topSpeed < 160 || topSpeed > 250)
            {
                throw new ArgumentOutOfRangeException("Engine size should be between 160 and 250");
            } else
            {
                this.TopSpeed = topSpeed;
            }
        }

        public override string ToString() {
            return String.Format("Car -> Engine size: {0}, Weight: {1}, Top Speed: {2}", this.EngineSize, this.Weight, this.TopSpeed);
        }

        public int CompareTo(Car other)
        {
            return other.TopSpeed - this.TopSpeed;
        }
    }
}
