using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14SustitucionLiskov
{
    public class Pinguino : AveVoladora
    {
        public override void Volar()
        {
            throw new NotImplementedException();
        }

    }
}
