using CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase15.Clases
{
    public class GerenteRRHH : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override int SueldoBase => 8000;

        public decimal CalcularBonificacion()
        {
            return 1000m;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }

        public decimal DescontarSueldo()
        {
            return SueldoBase * Constantes.DescuentoGerenteRRHH;
        }
    }
}
