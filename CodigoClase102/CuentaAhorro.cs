using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase102
{
    public class CuentaAhorro : Cuenta
    {
        public override void Retirar(decimal monto)
        {
            if (monto >= Saldo)
            {
                Console.WriteLine("No se puede realizar el retiro, saldo es insuficiente");
            }
            else
            {
                Saldo = Saldo - monto;
            }

        }

        public override void MostrarDetalle()
        {
            Console.WriteLine(NumeroCuenta);
            Console.WriteLine(Titular);
            Console.WriteLine(Saldo);
        }
    }
}
