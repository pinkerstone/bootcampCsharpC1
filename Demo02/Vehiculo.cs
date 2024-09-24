using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public abstract class Vehiculo
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }

        public abstract void PrecioVenta();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine(Marca);
            Console.WriteLine(Modelo);
        }
    }
}
