using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class PartTimeStudent : PartTimeEmployee, IStudent
    {
        private int startyear;

        public int Startyear
        {
            get { return startyear; }
            set { startyear = value; }
        }

        public virtual void Register( int year )
        {
            Startyear = year;
        }

        public PartTimeStudent( string name, double hourlyWage, int hoursPrMonth, int startyear )
            : base(name, hourlyWage, hoursPrMonth )
        {
            Register(startyear);
        }
   }
}
