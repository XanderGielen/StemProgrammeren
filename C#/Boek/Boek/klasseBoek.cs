using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    internal class klasseBoek
    {
        public int Isbn {  get; set; }
        public string Title {  get; set; }
        public string Auteur {  get; set; }

        public virtual double Prijs {  get; set; }

        public static klasseBoek TelOp(klasseBoek boek1, klasseBoek boek2)
        {
            klasseBoek tijdelijkboek = new klasseBoek();
            tijdelijkboek.Title = "ömnibus van " + boek1.Title + " en " + boek2.Title;
            tijdelijkboek.Prijs = (boek1.Prijs + boek2.Prijs) / 2;
            return tijdelijkboek;
        } 
        
    }
}
