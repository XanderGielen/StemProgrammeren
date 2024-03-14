using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    internal class BankRekening : Rekening
    {
        
        public override double BerekenRente()
        {
            double rente = 0;
            if (Saldo > 100) { rente = Saldo *0.05; }
            return rente;
        }
    }
}
