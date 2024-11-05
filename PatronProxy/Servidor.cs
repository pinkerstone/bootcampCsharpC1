using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    public class Servidor
    {
        //Clase principal protegida por proxy
        public void ProcesarSolicitud()
        {
            Console.WriteLine("Procesando solicitud");
        }
    }
}
