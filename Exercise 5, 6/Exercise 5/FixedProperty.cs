using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    abstract class FixedProperty
    {
        protected string location;
        protected bool inCity;
        protected decimal estimatedValue;

        public FixedProperty(string loc, bool inC, decimal eValc) {
            this.location = loc;
            this.inCity = inC;
            this.estimatedValue = eValc;
        }
    }
}
