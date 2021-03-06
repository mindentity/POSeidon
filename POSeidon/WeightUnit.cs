﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public class WeightUnit
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double Ratio { get; set; }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Name, Symbol);
        }
    }
}
