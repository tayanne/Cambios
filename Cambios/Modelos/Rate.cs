﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cambios.Modelos
{
    public class Rate
    {
        public int RateId { get; set; }

        public string Code { get; set; }

        public double TaxRate { get; set; }

        public string Name { get; set; }

        //public override string ToString()
        //{
        //    return $"{Name}";

        //}
    }
}
