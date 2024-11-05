using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronClonar
{
    public class Laptop
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public Laptop(string nombre, int precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public Laptop ManualClone()
        {
            return new Laptop (Nombre, Precio, Stock);
        }

        public Laptop Clone()
        {
            return (Laptop)MemberwiseClone();
        }
    }
}
