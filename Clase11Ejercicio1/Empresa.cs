using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Ejercicio1
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public GiroNegocio GiroNegocio { get; set; }
        public List<Trabajador> Trabajadores { get; set; }
        public List<Area> Areas { get; set; }
        public List<Sucursal> Sucursales { get; set; }

    }
}
