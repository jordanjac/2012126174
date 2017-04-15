using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class Transporte : Servicio
    {
        public Cliente _cliente;
        public TipoViaje _tipoViaje;
        public LugarViaje _lugarviaje;

        private List<Bus> _Buses;

        public List<Bus> Buses
        {
            get
            {
                return _Buses;
            }

            set
            {
                _Buses = value;
            }
        }

        public Transporte(List<Bus> buses)
        {
            Buses = buses;
        }
         
       







        }



    }

