using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVraag2
{
    internal class Vrachtwagen : Voertuig
    {
        public int Belading { get; }

        public Vrachtwagen(string Merk, string Type, int Belading) : base(Merk, Type)
        {
            this.Belading = Belading;
        }
        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine("Belading: " + Belading);
        }
    }
}
