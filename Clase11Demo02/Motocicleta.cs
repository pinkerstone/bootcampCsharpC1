using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Demo02
{
    public class Motocicleta : IBicicleta, IMotor
    {
        public void Acelerar(int incremento)
        {
            Console.WriteLine($"La motocicleta incremento en {incremento}");
        }

        public void Arrancar()
        {
            Console.WriteLine("La moticicleta está arrancando");
        }

        public void Apagar()
        {
            Console.WriteLine("La motocicleta está apagada");
        }
    }
}
