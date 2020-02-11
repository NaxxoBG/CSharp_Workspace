using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    abstract class Employee : IComparable<Employee>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Implement the CompareTo method. For the parameter type, Use 
        // the type specified for the type parameter of the generic 
        // IComparable interface. 
        //
        public int CompareTo( Employee other )
        {
            // The temperature comparison depends on the comparison of the
            // the underlying values. Because the CompareTo method is
            // strongly typed, it is not necessary to test for the correct
            // object type.
            return name.CompareTo( other.name );
        }

        public Employee(string name)
        {
            this.name = name;
        }

        public abstract double getMonthSalary();
    }
}
