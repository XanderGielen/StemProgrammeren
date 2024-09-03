using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVraag2
{
    internal class Moto : Voertuig
    {
        public double Vermogen { get; }

        public Moto(string Merk, string Type, double Vermogen) : base(Merk, Type)
        {
            this.Vermogen = Vermogen;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine("Vermogen: " + Vermogen);
        }
    }
}
