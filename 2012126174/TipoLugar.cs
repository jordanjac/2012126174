using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    class TipoLugar
    {
        public static int origen=1;
        public static int destino=0;
        public String Lugar { set; get; }

        public TipoLugar(int i)
        {
            if (i == destino)
            {
                Lugar = "Origen";
            }
            else
            {
                Lugar = "Destino";
            }
            Lugar = String.Empty;
        }
    }
}
