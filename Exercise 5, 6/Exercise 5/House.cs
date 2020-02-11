using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class House : FixedProperty, ITaxable
    {
        protected double area;

        public House(double a, string loc, bool inC, decimal eVal) : base(loc, inC, eVal) {
            this.area = a;
        }

        public decimal TaxValue()
        {
            decimal percentage = new decimal(0.4);
            return this.estimatedValue * percentage;
        }
    }
}
