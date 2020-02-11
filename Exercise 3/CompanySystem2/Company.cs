using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem2
{
    class Company
    {
        private List<Employee> employees;

        public Company() {
            this.employees = new List<Employee>();
        }

        public double GetMonthlySalaryTotal() {
            double total = 0.0d;
            foreach (Employee e in employees)
            {
                total += e.GetMonthSalary();
            }
            return total;
        }

        public void EmployNewEmployee(Employee newEmployee) {
            employees.Add(newEmployee);
        }
    }
}
