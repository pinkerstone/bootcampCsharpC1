using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase_06_11_2024
{
    public class Euros : IMoneda
    {
        private static string Nombre = "Euros";

        public string Moneda()
        {
            return Nombre;
        }

    }
}
