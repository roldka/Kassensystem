﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem.ViewModel
{
    public class GesamtGewicht
    {
        public GesamtGewicht()
        {
            Gewicht = GlobaleVariablen.Gewicht;
        }

        public float Gewicht { get; private set; }

        public void GesamtGewichtErhöhen()
        {
            Gewicht = GlobaleVariablen.Gewicht;
        }
    }
}
