using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Bus : Vehicle, ITaxable
    {
        private int numberOfSeats;
        public Bus(int noOfSeats, int registrationNumber, double maxVelocity, decimal value) : base(registrationNumber, maxVelocity, value)
        {
            this.numberOfSeats = noOfSeats;
        }

        public decimal TaxValue()
        {
            return value * new decimal(0.25);
        }
    }
}
