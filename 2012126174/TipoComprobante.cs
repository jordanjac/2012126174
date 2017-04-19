using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class TipoComprobante
    {
        public static int boleta=0;
        public static int factura=1;
        public String Comprobante { get; }

        public TipoComprobante(int i)
        {
            if (i == boleta)
            {
                Comprobante = "BOLETA";
            }
            else
            {
                Comprobante = "FACTURA";
            }
        }
    }
}
