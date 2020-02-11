using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    class FullTimeEmployee : Employee
    {
        private double monthlySalary;

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override double GetMonthSalary()
        {
            Console.WriteLine("Method from FullTimeEmployee");
            return monthlySalary;
        }
    }
}
