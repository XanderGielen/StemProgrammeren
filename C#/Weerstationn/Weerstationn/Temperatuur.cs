using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weerstationn
{
    internal class Temperatuur : Meting
    {
        public bool vriesTemp
        {
            get
            {
                return OmgezetteWaarde() < 0;
            }
        }
        public Temperatuur(double slope, double intercept) : base(slope, intercept, "C")
        {
            
        }
    }
}
