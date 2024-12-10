using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDetalle
    {
        public List<EDetalle> Listar(EDetalle entidad)
        {
            List<EDetalle> eDetalles = new List<EDetalle>();
            DDetalle dDetalle = new DDetalle();
            eDetalles = dDetalle.ListarDetalle(entidad);
            return eDetalles;

        }

        public void Insertar(EDetalle eDetalle)
        {
            DDetalle dDetalle = new DDetalle();
            dDetalle.Insertar(eDetalle);
        }
    }
}
