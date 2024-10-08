using CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase15.Clases
{
    public class Gerente : EmpleadoBase,ISueldoBonificable,IDescuentoImpuesto
    {        
        //=> Lambda: Funciones pequeñas
        public override int SueldoBase => 8000;

        public decimal CalcularBonificacion()
        {
            return 1000m;
        }
        public decimal DescontarSueldo()
        {
            return SueldoBase * Constantes.DescuentoGerente;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }

        
    }
}
