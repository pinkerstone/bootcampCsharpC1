﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Ejercicio02Interfaces
{
    public class ClienteVip : IDeuda
    {

        public double CostoServicio { get; set; }
        public double DescuentoVIP { get; set; }

        public double CalcularDeuda()
        {
            return CostoServicio - DescuentoVIP;
        }
    }
}