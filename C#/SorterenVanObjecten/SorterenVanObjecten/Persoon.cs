using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SorterenVanObjecten
{
    internal class Persoon : IComparable<Persoon>
    {
        public Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        public String Voornaam {  get; set; }
        public String Achternaam {  get; set; }

        public int CompareTo(Persoon other)
        {
            if (this.Achternaam == other.Achternaam && this.Voornaam == other.Voornaam)
            {
                return 0;
            }
            else
            {
                int achternaam = this.Achternaam.CompareTo(other.Achternaam);
                if (achternaam == 0)
                {
                    return this.Voornaam.CompareTo(other.Voornaam);
                }
                else
                {
                    return achternaam;
                }
            }
        }
    }
}
