using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class Cliente
    {
        public String DNI { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }

        public Cliente()
        {
            DNI = String.Empty;
            Nombres = String.Empty;
            Apellidos = String.Empty;
        }
    }
}
