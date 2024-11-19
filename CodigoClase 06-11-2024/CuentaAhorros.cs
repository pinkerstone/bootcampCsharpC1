using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase_06_11_2024
{
    public class CuentaAhorros : Cuenta
    {

        private static string tipo = "ahorros";

        public CuentaAhorros(IMoneda _moneda) : base(_moneda)
        {
            moneda = _moneda;
        }

        public override void CrearCuenta()
        {
            Console.WriteLine($"Creando cuenta de {tipo} en moneda {moneda.Moneda()}");
        }
    }
}
