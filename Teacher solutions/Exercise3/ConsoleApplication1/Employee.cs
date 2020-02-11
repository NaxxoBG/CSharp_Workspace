using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    abstract class Employee 
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Employee(string name)
        {
            this.name = name;
        }

        public abstract double getMonthSalary();
    }
}
