using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class Administrativo : Empleado
    {
        public String Cargo { get; set; }
        public Administrativo(String dni, String nombres, String apellidos, int edad, Decimal sueldo) : base(dni, nombres, apellidos, edad, sueldo)
        {
            Cargo = String.Empty;
        }
    }
}
