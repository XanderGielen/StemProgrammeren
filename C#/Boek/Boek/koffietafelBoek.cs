using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    internal class koffietafelBoek : klasseBoek
    {
        private double nuPrijs = 0;
        public override double Prijs
        {
            get
            {
                if (nuPrijs > 35 && nuPrijs < 100)
                {
                    return nuPrijs;
                }
                else
                {
                    return -666;
                }
            }
            set
            {
                nuPrijs = value;
            }
        }
    }
}
