using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVraag2
{
    internal class Auto : Voertuig
    {
        public int Deuren { get; }

        public Auto(string Merk, string Type, int Deuren) : base(Merk, Type)
        {
            this.Deuren = Deuren;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
            Console.WriteLine("Deuren: " + Deuren);
        }
    }
}
