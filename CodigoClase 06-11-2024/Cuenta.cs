using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase_06_11_2024
{
    public abstract class Cuenta
    {
        protected IMoneda moneda;

        public Cuenta(IMoneda _moneda)
        {

        }

        public abstract void CrearCuenta();

    }
}
