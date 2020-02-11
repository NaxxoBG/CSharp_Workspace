using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPrMonth;

        public PartTimeEmployee(string name, double hourlyWage, int hoursPrMonth)
            : base(name)
        {
            this.hoursPrMonth = hoursPrMonth;
            this.hourlyWage = hourlyWage;
        }
        public override double getMonthSalary()
        {
            return (hourlyWage * hoursPrMonth);
        }
    }
}
