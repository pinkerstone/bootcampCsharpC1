using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class PersonaModel
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion {  get; set; }
        public int Edad {  get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }

    }
}
