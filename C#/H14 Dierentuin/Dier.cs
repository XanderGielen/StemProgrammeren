using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace H14_Dierentuin
{
    internal abstract class Dier
    {
        public double Gewicht { get; set; }

        public abstract string Zegt();

    }
    internal class Hond : Dier
    {
        
        public override string Zegt() {  
            return "Woef"; }
    }
    internal class Kat : Dier
    {
        public override string Zegt() { return "Miauw"; }
    }
    internal class Eend : Dier
    {
        public override string Zegt() { return "Kwek"; }
    }
    internal class Koe : Dier
    {
        public override string Zegt() { return "Moe"; }
    }


}
