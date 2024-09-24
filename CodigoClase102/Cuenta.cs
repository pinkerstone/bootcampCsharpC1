using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase102
{
    public abstract class Cuenta
    {
        public string NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Retirar(decimal monto);

        public void Depositar(decimal monto)
        { 
            Saldo = monto;
        }

        public abstract void MostrarDetalle();

    }
}
