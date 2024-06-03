using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weerstationn
{
    internal class DrukMeting : Meting
    {
        public DrukMeting(double slope, double intercept) : base(slope, intercept, "hPa")
        {

        }
    }
}
