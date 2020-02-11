using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem2
{
    class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPerMonth;

        public PartTimeEmployee(string name, double wage, int hours) : base(name) {
            hourlyWage = wage;
            hoursPerMonth = hours;
        }

        public override double GetMonthSalary()
        {
            return hourlyWage * hoursPerMonth;
        }
    }
}
