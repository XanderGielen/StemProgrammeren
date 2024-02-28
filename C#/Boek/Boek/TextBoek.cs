using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    internal class TextBoek : klasseBoek
    {
        public int GradeLevel {  get; set; }
        private double nuPrijs = 0;
        public override double Prijs 
        {
            get
            {
                if (nuPrijs > 20 && nuPrijs < 80)
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
