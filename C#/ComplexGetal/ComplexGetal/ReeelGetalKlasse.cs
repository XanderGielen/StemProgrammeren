using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexGetal
{
    internal class ReeelGetalKlasse : ComplexGetalKlasse
    {
        public ReeelGetalKlasse(double a) : base(a, 0)
        {
            Reeel = a;
        }
        public override string ToString()
        {
            return this.Reeel.ToString();
        }
    }
}
