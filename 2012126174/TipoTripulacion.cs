using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
   public  class TipoTripulacion
    {
        public static int conductor = 0;
        public static int terramoza = 1;

        public String Nombre { get; }

        public TipoTripulacion(int i)
        {
            if (i == conductor)
            {
                Nombre = "Tripulante Conductor";
            }
            else
            {
                Nombre = "Tripulante Terramoza";
            }
        }

    }
}
