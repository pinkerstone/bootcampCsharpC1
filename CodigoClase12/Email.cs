﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class Email : INotificacion
    {

        public void Enviar()
        {
            Console.WriteLine("Enviando email");
        }
    }
}
