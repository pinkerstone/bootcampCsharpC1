using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Trabajador
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public int SueldoBruto { get; set; }

        double CalcularDescuento()
        {
            return SueldoBruto * Impuesto.RecibosHonorarios;
        }

        public double CalcularSueldoNeto()
        {
            return SueldoBruto - CalcularDescuento();
        }

    }
}
