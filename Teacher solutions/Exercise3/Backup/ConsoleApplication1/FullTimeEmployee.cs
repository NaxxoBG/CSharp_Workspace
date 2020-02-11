using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
     class FullTimeEmployee : Employee
    {
        private double monthSalary;

        public FullTimeEmployee(string name, double monthSalary)
            : base( name )
        {
            this.monthSalary = monthSalary;
        }
        public override double getMonthSalary()
        {
            return monthSalary;
        }
    }
}
