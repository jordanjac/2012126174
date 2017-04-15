using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
   public class Encomienda : Servicio
    {
        private LugarViaje _lugarviaje;



        public int EncomiendaID { get; private set;}
        public Bus Bus { get; set; }

        public Encomienda()
        {

        }

        public Encomienda (Bus bus)
        {
            Bus = bus;
        }

        public Encomienda (int encomiendaID)
        {
            EncomiendaID = EncomiendaID;
        }





    }
}
