using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public class TarjetaCredito : Cuenta
    {
        public string Marca {  get; set; }
    
        public override void Depositar(double monto)
        {

        }

        public override void MostrarInformacion()
        {
            Console.WriteLine(NumCuenta);
            Console.WriteLine(Saldo);
            Console.WriteLine(Marca);
        }
    }
}
