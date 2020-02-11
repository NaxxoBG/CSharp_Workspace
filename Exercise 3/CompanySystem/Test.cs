using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem
{
    class Test
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.WriteLine(company.GetMonthlySalaryTotal());
            Console.ReadLine();

            company.EmployNewEmployee(new PartTimeEmployee("Jack", 30, 96));

            Console.WriteLine(company.GetMonthlySalaryTotal());
            Console.ReadLine();

            company.EmployNewEmployee(new FullTimeEmployee("Jim", 20000));

            Console.WriteLine(company.GetMonthlySalaryTotal());
            Console.ReadLine();
        }
    }
}