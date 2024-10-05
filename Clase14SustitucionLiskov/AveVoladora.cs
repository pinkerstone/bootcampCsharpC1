using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14SustitucionLiskov
{
    public abstract class AveVoladora : Ave
    {
        public override void Comer()
        {
            throw new NotImplementedException();
        }

        public abstract void Volar();
    }
}
