using System.Linq.Expressions;

namespace LottoReader
{
    internal class LottoTrekking
    {
        public static int AantalNummers { get { return 45; } }
        private const char LISTSEPARATOR = ';';
        public class PrijzenGeld
        {
            public int Rang { get; private set; }
            public int Winnaars { get; private set; }
            public double Winst { get; private set; }
            //Totale winst berekent hoeveel winst er in deze rang werd uitgekeerd.
            public double TotaleWinst { get { return Winnaars * Winst; } }

            public PrijzenGeld(int rang, int winnaars, double winst)
            {
                /// financialData hoofding:
                /// P-R1  -> aantal winnaars in Rang 1
                /// W-R1  -> winst/winnaar in Rang 1
                Rang = rang;
                Winnaars = winnaars;
                Winst = winst;
            }
        }

        public DateTime Datum { get; private set; }
        public PrijzenGeld[] Winstuitkering { get; private set; } = new PrijzenGeld[9];
        public int[] Nummers { get; private set; } = new int[6];
        public int Bonus { get; private set; }

        public List<int> GeefAlleNummers(bool inclusiefbonus = true)
        {
            List<int> result = Nummers.ToList();
            if (inclusiefbonus) result.Add(Bonus);
            return result;
        }

        public LottoTrekking(string financialDataLine, string gameDataLine)
        {
            string[] financialDataItems = financialDataLine.Split(LISTSEPARATOR);
            string[] gameDataItems = gameDataLine.Split(LISTSEPARATOR);

            try
            {
                // sanity check, de eerste elementen van de dataItems arrays moeten gelijk zijn
                if (financialDataItems[0] != gameDataItems[0])
                {
                    throw (new DatumIsNietGelijkException());
                }
            }
            catch (DatumIsNietGelijkException)
            {
                Console.WriteLine("datums zijn niet gelijk");
            }


            Datum = DateTime.ParseExact(financialDataItems[0], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            //TODO: lees documentatie op https://learn.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-8.0

            for (int i = 1; i <= 6; i++)
            {
                Nummers[i -1] = Convert.ToInt32(gameDataItems[i]);
            }

            Bonus = Convert.ToInt32(gameDataItems[7]);

            int counter = 1;
            for (int i = 1; i < financialDataItems.Length; i+= 2)
            {
                if (i > 2)
                {
                    
                    Winstuitkering[counter -1] = new PrijzenGeld(counter, Convert.ToInt32(financialDataItems[i]), Convert.ToDouble(financialDataItems[i+1]));
                    counter++;
                }
            }
        }
    }

    public class DatumIsNietGelijkException : Exception
    {
    }
}
