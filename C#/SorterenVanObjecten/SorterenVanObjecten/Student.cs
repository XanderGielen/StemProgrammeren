using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorterenVanObjecten
{
    internal class Student : Persoon
    {
        public Student(string Voornaam, string Achternaam, string klas) : base(Voornaam, Achternaam)
        {
            Klas = klas;
        }

        public string Klas {  get; set; }
    }
}
