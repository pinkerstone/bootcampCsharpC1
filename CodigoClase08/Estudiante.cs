using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Estudiante : Persona
    {

        public List<string> Materias { get; set; }
        public List<double> Notas {  get; set; }
        public Escuela Escuela { get; set; }


        public double CalcularPromedio()
        {
            return Notas.Average();
        }



    }


}
