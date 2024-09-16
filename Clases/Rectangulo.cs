using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Rectangulo
    {
        public int base1;
        public int altura;

        public int CalcularArea()
        {
            return base1 * altura;
        }

        public int CalcularPerimetro()
        {
            return (base1 + altura) * 2;
        }
    }
}
