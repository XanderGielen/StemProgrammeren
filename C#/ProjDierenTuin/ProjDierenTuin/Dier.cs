using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjDierenTuin
{
    abstract class Dier
    {
        public double gewicht {  get; set; }
        public abstract string Zegt();
    }
}
