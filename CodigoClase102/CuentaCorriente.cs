using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase102
{
    public class CuentaCorriente : Cuenta
    {
        public override void Retirar(decimal monto)
        {
            monto = (monto * 1.02m);
            Saldo = Saldo - monto;
        }

        public override void MostrarDetalle()
        {
            Console.WriteLine(NumeroCuenta);
            Console.WriteLine(Titular);
            Console.WriteLine(Saldo);
        }
    }

}
