using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase_06_11_2024
{
    public class Dolares : IMoneda
    {

        private static string nombre = "Dólares";

        public string Moneda()
        {
            return nombre;
        }
    }
}
