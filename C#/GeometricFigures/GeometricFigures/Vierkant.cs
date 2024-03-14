using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Vierkant : Geomatricfigure
    {
        public Vierkant(int breedte, int hoogte)
        {
            if (breedte != hoogte)
            {
                breedte = hoogte;
            }
        }
        public Vierkant(int lengteEnBreedte)
        {
            public int Oppervlakte
        {

            get
            {
                return BerekenOppervlakte();
            }
        }
    } 
}
