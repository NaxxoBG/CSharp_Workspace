using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Company
    {
        private List<Employee> employees = new List<Employee>();
 
        public void employNewEmployee( Employee e )
        {
            employees.Add( e );
        }

        public double getMonthSalaryTotal()
        {
            double total = 0.0;
            foreach( Employee e in employees )
            {
                total += e.getMonthSalary();
            }
            return total;
        }
    }
}
