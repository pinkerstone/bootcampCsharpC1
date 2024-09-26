using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Demo02
{
    public class Coche : Vehiculo
    {
        public override void Acelerar(int incremento)
        {
            Console.WriteLine($"El coche incrementó en {incremento}");
        }

        public override void Encender()
        {
            Console.WriteLine("Encendiendo el coche");
        }
    }
}
