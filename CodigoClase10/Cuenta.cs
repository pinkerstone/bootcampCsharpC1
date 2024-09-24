using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10
{
    public abstract class Cuenta
    {
        public string NumCuenta { get; set; }
        public double Saldo { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine(NumCuenta);
            Console.WriteLine(Saldo);

        }

        public abstract void Depositar(double monto);
       

    }
}
