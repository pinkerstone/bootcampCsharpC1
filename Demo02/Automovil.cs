using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Automovil : Vehiculo
    {
        public bool Pantalla {  get; set; }
        public override void PrecioVenta()
        {
            Console.WriteLine("Calculando precio de venta");
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
            Console.WriteLine(Pantalla);
        }
    }
}
