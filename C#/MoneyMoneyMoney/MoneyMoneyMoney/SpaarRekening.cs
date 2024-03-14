using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    internal class SpaarRekening : Rekening
    {
        public override double BerekenRente()
        {
            double rente = Saldo * 0.02;
            return rente;
        }
    }
}
