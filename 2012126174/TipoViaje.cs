using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class TipoViaje
    {
        public static int normal = 0;
        public static int vip = 1;
        public String Viaje { get; }

        public TipoViaje(int i)
        {
            if (i == normal)
            {
                Viaje = "Bus Normal";
            }
            else
            {
                Viaje = "Bus Cama";
            }

        }



    }
}
