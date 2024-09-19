using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase08
{
    public class Profesor
    {
        #region Propiedades
        public string Nombres {  get; set; }
        public string Apellidos { get; set; }
        public double Sueldo { get; set; }
        public string TipoDocumento { get; set; }
        public int EscalaSalarial { get; set; }
        public DateTime FechaIngreso { get; set; }
        #endregion

        public string ObtenerNombresCompletos()
        {
            return $"{Nombres} {Apellidos}";
        }

        public void AsignarSueldo()
        {
            switch (EscalaSalarial)
            {
                case 1:
                    Sueldo = 1000;
                    break;
                case 2:
                    Sueldo = 2000;
                    break;
                case 3:
                    Sueldo = 3000;
                    break;
            }
        }

        public int AniosTrabajados()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }
       
    }

}
