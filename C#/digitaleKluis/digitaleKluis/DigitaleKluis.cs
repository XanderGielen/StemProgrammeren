using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitaleKluis
{
    internal class DigitaleKluis
    {
        private int code;

        public int Code
        {
            get
            {
                if (CanShowCode)
                {
                    return code;
                }
                else
                {
                    return -666;
                }
            }
            private set
            {
                code = value;
            }
        }
    

        public DigitaleKluis(int codeIn)
        {
            code = codeIn;
        }
        public bool CanShowCode { get; set; } = false;

        public int CodeLevel
        {
            private get
            {
                return code / 1000;
            }
            set { }
        }

        private int aantalPogingen;
        public bool TryCode(int poging)
        {
            aantalPogingen++;
            if (aantalPogingen >= 10)
            {
                Console.WriteLine("je hebt 10 pogingen gebruikt, sorry");
            }
            else
            {
                if (poging == code)
                {
                    Console.WriteLine("code is geldig");
                    Console.WriteLine("je hebt " + aantalPogingen + " keer geprobeerd");
                    return true;
                }
                else if (poging == -666)
                {
                    Console.WriteLine("Cheater");
                }
                else
                {
                    Console.WriteLine("Geen geldige code");
                }

            }
            return false;
        }
    }
}
