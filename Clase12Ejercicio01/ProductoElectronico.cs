﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Ejercicio01
{
    public class ProductoElectronico : IPedido
    {

        public void EnviarPedido()
        {
            Console.WriteLine("Enviando a Proveedor A");
        }
    }
}
