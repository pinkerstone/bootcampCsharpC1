using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Demo02
{
    public class Bicicleta : Vehiculo
    {
        public override void Acelerar(int incremento)
        {
            Console.WriteLine($"La bicicleta incrementó en {incremento}");
        }

        public override void Encender()
        {
            Console.WriteLine("La bicicleta está lista para ser usada");
        }

    }
}
