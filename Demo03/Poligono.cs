using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public static class Poligono
    {
        public static double CalcularArea(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularArea(double base1, double altura)
        {
            return base1 * altura;
        }

        public static double CalcularArea(double base1, double altura)
        {
            return (base1 * altura) / 2;
        }
    }
}
