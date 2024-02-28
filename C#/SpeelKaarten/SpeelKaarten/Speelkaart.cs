using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeelKaarten
{
    internal class Speelkaart
    {
        public int Getal { get; private set; }
        public enum Suite
        {
            Schoppen,
            Harten,
            Klaveren,
            Ruiten
        }
        public Suite Soort { get; private set; }

        public Speelkaart(int getal, Suite soort)
        {
            Getal = getal;
            Soort = soort;
        }

    }
}
