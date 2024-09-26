using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Demo02
{
    public class MotorElectrico : IMotor
    {

        public void Apagar()
        {
            Console.WriteLine("Apagando motor a electrico");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando motro a electrico");
        }
    }
}
