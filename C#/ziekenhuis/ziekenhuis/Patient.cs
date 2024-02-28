using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziekenhuis
{
    internal class Patient
    {
        public string naam {  get; set; }
        public int uur { get; set; }

        public virtual double BerekenKost()
        {
            float kost = 50 + 20 * uur;
            return kost;
        }

        public string InfoFiche()
        {
            string alleInfo = naam + " " + uur + " " + BerekenKost().ToString();
            return alleInfo;
        }
    }
}
