using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterenVanObjecten
{
    internal class Personeel : Persoon
    {
        public Personeel(string Voornaam, string Achternaam, int personeelsNummer) : base(Voornaam, Achternaam)
        {
            PersoneelsNummer = personeelsNummer;
        }
        public int PersoneelsNummer {  get; set; }
    }
}
