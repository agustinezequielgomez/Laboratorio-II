﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAFIP
    {
        double MiPropiedad { get; set; }
        double CalcularImpuesto();
    }
}
