using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    public class Operaciones
    {

        private int valor1;
        private int valor2;

        public void AsignarValores(int pvalor1, int pvalor2)
        {
            this.valor1 = pvalor1;
            this.valor2 = pvalor2;
        }

        public int Sumar()
        {
            return valor1 + valor2;
        }

        public int Restar()
        {

            if (valor1 < valor2)
            {
                throw new CustomException();
            }

            return valor1 - valor2;
        }

        public double Dividir()
        {

            double resultado = valor1 / valor2;
            return resultado;

        }
    }
}
