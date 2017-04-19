using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class TipoPago
    {
        public static int efectivo=0;
        public static int tarjeta=1;
        public static int deposito=2;
        public String pago { get; }

        public TipoPago(int i)
        {
          
            if (i == 0)
            {
                pago = "Efectivo";
            }else if (i == 1)
            {
                pago = "Tarjeta";
            }
            else
            {
                pago = "Deposito";
            }

        }
    }
}
