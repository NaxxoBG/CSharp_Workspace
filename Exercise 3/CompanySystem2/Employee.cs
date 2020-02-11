using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem2
{
     abstract class Employee
    {
        private string name;

        public Employee(String name) {
            this.name = name;
        }

        public abstract double GetMonthSalary();

    }
}
