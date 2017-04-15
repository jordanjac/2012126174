using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
   public class Bus
    {
        private List<Tripulacion> _Tripulaciones;



        public List<Tripulacion> Tripulaciones
        {
            get
            {
                return _Tripulaciones;
            }
            set
            {
                _Tripulaciones = value;
            }
        }

        public Bus(List<Tripulacion> tripulaciones)
        {
            Tripulaciones = tripulaciones;
        }

        public String bus(string tipoViaje)
        {
            if (tipoViaje == "VIP"){
                return "Bus Cama";
            }
            else
            {
                return "Bus Normal";
            }
        }








        }
    }

