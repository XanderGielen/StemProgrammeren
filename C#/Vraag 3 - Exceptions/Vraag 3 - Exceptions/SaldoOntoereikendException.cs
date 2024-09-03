using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_3___Exceptions
{
    internal class SaldoOntoereikendException : Exception
    {
        public SaldoOntoereikendException(string message) : base(message) { }
    }
}
