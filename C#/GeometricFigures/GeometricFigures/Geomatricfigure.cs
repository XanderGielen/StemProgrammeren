using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    abstract class Geomatricfigure
    {
        public int Hoogte {  get; set; }
        public int Breedte { get; set; }

        public int Oppervlakte
        {
            get
            {
                return BerekenOppervlakte();
            }
        }
        public virtual int BerekenOppervlakte()
        {
            return Hoogte * Breedte;
        }
    }
}
