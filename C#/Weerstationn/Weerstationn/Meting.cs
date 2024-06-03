using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weerstationn
{
     abstract class Meting
    {
        private double slope, intercept;
        public string eenheid;
        public Meting(double slope, double intercept, string eenheid)
        {
            this.slope = slope;
            this.intercept = intercept;
            this.eenheid = eenheid;
        }

        private List<double> LaatsteMetingen { get; set; } = new List<double>();

        public double Gemiddelde
        {
            get
            {
                //return LaatsteMetingen.Average();
                double totaal = 0;
                foreach (double nummer in LaatsteMetingen)
                {
                    totaal += nummer;
                }
                return totaal / LaatsteMetingen.Count;
            }
        }

        public double Minimum { get { return LaatsteMetingen.Min();} }
        public double Maximum { get { return LaatsteMetingen.Max(); } }

        public void WisLaatsteMetingen()
        {
            LaatsteMetingen.Clear();
        }

        public void VoegMetingenToe(double toegevoegdeWaarde)
        {
            LaatsteMetingen.Add(toegevoegdeWaarde);
        }

        public double OmgezetteWaarde()
        {
            return OmgezetteWaarde(LaatsteMetingen.Last());
        }

        public double OmgezetteWaarde(double x)
        {
            return x * slope + intercept;
        }
        public double omgezetteWaardeVanGem { get { return OmgezetteWaarde(Gemiddelde); } }

    }
}
