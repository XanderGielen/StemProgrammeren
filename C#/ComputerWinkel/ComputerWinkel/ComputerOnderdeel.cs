using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWinkel
{
    internal class ComputerOnderdeel
    {
        public int Prijs {  get; set; }
        public int ID { get; set; }
        public bool InDoos {  get; set; }
        
        public ComputerOnderdeel() 
        {
            Random randomnum = new Random();
            Prijs = randomnum.Next(1000);
            ID = randomnum.Next(100, 999);
            InDoos = randomnum.Next(0, 2) == 1;
        }
        public void ToonInfo()
        {
            Console.WriteLine("Prijs " + Prijs + " ID: " + ID + " InDoos: " + InDoos);

        }
    }


}
