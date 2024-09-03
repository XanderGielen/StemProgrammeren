using Vraag_3___Exceptions;

namespace Vraag_3_Exceptions
{
    public class Bankrekening
    {
        public string Naam { get; private set; }
        private double Saldo { get; set; }

        public Bankrekening(string naam)
        { 
            Naam = naam;
            Saldo = 0.0;
        }

        public void ToonSaldo()
        {
            Console.WriteLine($"Het saldo bedraagt {Saldo}");
        }


        public void Storten(double bedrag)
        {
            try
            {
                if ( bedrag < 0.0 ) { throw new NegatiefBedragException("Het bedrag kan niet negatief zijn"); }
                Saldo += bedrag;
            }
            catch (NegatiefBedragException e) 
            {
                Console.WriteLine(e);
            }
        }

        public void Afhalen(double bedrag)
        {
            try
            {
                if ( Saldo < bedrag ) { throw new SaldoOntoereikendException("Saldo ontoereieknd"); }
                Saldo -= bedrag;
            }
            catch (SaldoOntoereikendException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
