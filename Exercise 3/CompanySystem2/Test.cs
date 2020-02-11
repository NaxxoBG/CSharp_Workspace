using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySystem2
{
    class Test
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.WriteLine(company.GetMonthlySalaryTotal());
            Console.ReadLine();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee("Jack", 30, 96);
            company.EmployNewEmployee(partTimeEmployee);

            Console.WriteLine(company.GetMonthlySalaryTotal());
            Console.ReadLine();

            company.EmployNewEmployee(new FullTimeEmployee("Jim", 20000));

            Console.WriteLine(company.GetMonthlySalaryTotal());
            Console.ReadLine();

            PartTimeStudent student = new PartTimeStudent("Tim", 20, 50);
            student.Register(2017);

            company.EmployNewEmployee(student);
        }
    }
}