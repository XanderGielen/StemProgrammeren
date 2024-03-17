using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ComplexGetal
{
    internal class ComplexGetalKlasse
    {
        public double Reeel {  get; set; }
        public double Imaginair {  get; set; }
        public ComplexGetalKlasse(double a, double b)
        {
            Reeel = a;
            Imaginair = b;
        }
        public static ComplexGetalKlasse operator +(ComplexGetalKlasse c1, ComplexGetalKlasse c2)
        {
            return new ComplexGetalKlasse(c1.Reeel + c2.Reeel, c1.Imaginair + c2.Imaginair);
        }
        public static ComplexGetalKlasse operator -(ComplexGetalKlasse c1, ComplexGetalKlasse c2)
        {
            return new ComplexGetalKlasse(c1.Reeel - c2.Reeel, c1.Imaginair + c2.Imaginair);
        }
        public static ComplexGetalKlasse operator *(ComplexGetalKlasse c1, ComplexGetalKlasse c2)
        {
            double Re = c1.Reeel * c2.Reeel - c1.Imaginair * c2.Imaginair;
            double Im = c1.Reeel * c2.Imaginair + c2.Reeel * c1.Imaginair;
            return new ComplexGetalKlasse(Re, Im);
        }
        public static ComplexGetalKlasse operator /(ComplexGetalKlasse c1, ComplexGetalKlasse c2)
        {
            ComplexGetalKlasse uitkomst = c1 * c2.Omgekeerde;
            return uitkomst;
        }
        public ComplexGetalKlasse Toegevoegde
        {
            get
            {
                return new ComplexGetalKlasse(Reeel, -Imaginair);
            }
        }
        protected double R2
        {
            get
            {
                return Reeel * Reeel + Imaginair * Imaginair;
            }
        }
        public double R
        {
            get
            {
                return Math.Sqrt(R2);
            }
        }
        public ComplexGetalKlasse Tegengestelde
        {
            get
            {
                if(Imaginair == 0)
                {
                    return new ReeelGetalKlasse(-Reeel);
                }
                ComplexGetalKlasse Tegengestelde = new ComplexGetalKlasse(-Reeel, -Imaginair);
                return Tegengestelde;
            }
        }
        public ComplexGetalKlasse Omgekeerde
        {
            get
            {
                double ReeelOmgekeerde = Reeel / R2;
                if (Imaginair == 0)
                {
                    return new ReeelGetalKlasse(ReeelOmgekeerde);
                }
                double ImaginairOmgekeerde = -Imaginair / R2;
                ComplexGetalKlasse Omgekeerde = new ComplexGetalKlasse(ReeelOmgekeerde, ImaginairOmgekeerde);
                return Omgekeerde;
            }
        }
        
        public override string ToString()
        {
            if(this.Imaginair > 0)
            {
                return this.Reeel.ToString() + "+" + this.Imaginair.ToString() + "i";
            }
            return this.Reeel.ToString() + this.Imaginair.ToString() + "i";
        }

    }
}
