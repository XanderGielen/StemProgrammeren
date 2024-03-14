using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    abstract class Rekening
    {
        private double saldo = 0.0;
        public double Saldo {  get { return saldo; } }
        public double VoegGeldToe(double geld)
        {
            saldo += geld;
            return saldo;
        }
        public double HaalGeldAf(double geld)
        {
            saldo -= geld;
            return saldo;
        }
        public abstract double BerekenRente();
    }
}
