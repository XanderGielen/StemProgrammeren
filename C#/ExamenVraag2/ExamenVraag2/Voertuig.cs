using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVraag2
{
    abstract class Voertuig
    {
        public string Merk { get;}
        public string Type { get;}

        public Voertuig(string Merk, string Type)
        {
            this.Merk = Merk;
            this.Type = Type;
        }

        public virtual void ToonInfo()
        {
            Console.WriteLine("Merk: " +  Merk);
            Console.WriteLine("Type" +  Type);
        }
    }
}
