using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
     class Transporte : Servicio
    {
        public LugarViaje Origen { get; set; }
        public LugarViaje Destino { get; set; }
        public TipoViaje TipoViaje { get; set; }
        public Cliente Cliente { get; set; }
        public Bus Bus { get; set; }

        public Transporte(int tipoviaje, int pasajeros, Tripulacion tripulacion)
        {
            TipoViaje = new TipoViaje(tipoviaje);
            Cliente = new Cliente();
            Bus = new Bus(pasajeros);
            this.NombreServicio = "Servicio de Transporte";
        }
  


    }

}

