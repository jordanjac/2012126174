using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    class Encomienda : Servicio
    {
        public LugarViaje Origen { get; set; }
        public LugarViaje Destino { get; set; }
        public double Peso { get; set; }
        public String Destinatario { get; set; }
        public Bus Bus { get; set; }


        public Encomienda()
        {
            Destinatario = String.Empty;
            NombreServicio = String.Empty;
            this.NombreServicio = "Servicio de Encomienda";
        }
       

    }
}
