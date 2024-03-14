using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMoneyMoney
{
    internal class ProRekening : SpaarRekening
    {
        public override double BerekenRente()
        {
            int extra = (Convert.ToInt32(Saldo) / 1000) * 10;
            double renteNu = base.BerekenRente();
            renteNu += extra;
            return renteNu;
        }
    }
}
