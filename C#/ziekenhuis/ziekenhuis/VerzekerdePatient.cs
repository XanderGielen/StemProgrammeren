﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziekenhuis
{
    internal class VerzekerdePatient : Patient
    {
        public override double BerekenKost()
        {
            return base.BerekenKost() * 0.9;
        }
    }
}
