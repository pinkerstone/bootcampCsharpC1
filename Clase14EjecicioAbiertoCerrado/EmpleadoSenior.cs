﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14EjecicioAbiertoCerrado
{
    public class EmpleadoSenior : Empleado
    {
        public override void CalcularBonificacion()
        {
            return SalarioBase * 0.3;
        }
    }
}
