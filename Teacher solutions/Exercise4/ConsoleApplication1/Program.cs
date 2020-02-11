using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            company.employNewEmployee( new FullTimeEmployee( "Kurt", 44000) );
            company.employNewEmployee( new FullTimeEmployee( "Hans", 33000) );

            company.employNewEmployee(new PartTimeEmployee("Ole", 200, 120 ));
            company.employNewEmployee(new PartTimeEmployee("Jan", 250, 100 ));


            company.employNewEmployee( new PartTimeStudent( "Kim", 250, 90, 2003 ) );

            Console.WriteLine("Total monthly salary: {0}", company.getMonthSalaryTotal());
            Console.ReadKey();

        }
    }
}
