using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
     public class Tripulacion :Empleado
    {
        public TipoTripulacion TipoTripulacion { get; set; }
        public int Cantidad { get; set; }

        public Tripulacion(String dni, String nombre, String apellidos,  int edad, int cantidad, int tipotripulacion, Decimal sueldo) : base(dni, nombre, apellidos,  edad, sueldo)
        {
            Cantidad = cantidad;
            TipoTripulacion = new TipoTripulacion(tipotripulacion);
        }
    }
}
