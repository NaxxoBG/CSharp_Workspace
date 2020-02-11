using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem2
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {
        private int startYear;

        public PartTimeStudent(string name, double wage, int hours) : base(name, wage, hours)
        {
        }

        public void Register(int year)
        {
            startYear = year;
        }
    }
}