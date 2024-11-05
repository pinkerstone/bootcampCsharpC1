using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    public class ProxyServidor
    {
        private Servidor _servidor;
        
        public ProxyServidor()
        {
            _servidor = new Servidor();
        }

        public void ProcesarSolicitud(string usuario)
        {
            if (usuario == "administrador")
            {
                Console.WriteLine("Acceso ok");
                _servidor.ProcesarSolicitud();
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
        }
    }

  
}
