using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class Empleado
    {
        public String DNI { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public Decimal Sueldo { get; set; }

        public Empleado(String dni, String nombres, String apellidos,  int edad, Decimal sueldo)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            DNI = dni;
            Edad = edad;
            Sueldo = sueldo;
        }
    }
}
