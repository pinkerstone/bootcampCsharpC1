using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    public static class Matematica
    {
    //Sobrecarga
    //static, al hacer una clase static implica que no es necesario instanciarla pero no puede ser alterada
    public static int Sumar(int a, int b)
        {
            return a + b;
        }   
    public static int Sumar(int a, int b, int c)
        {
            return (a + b + c);
        }
    public static int Sumar(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}
