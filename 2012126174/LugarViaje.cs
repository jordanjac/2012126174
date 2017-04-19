using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    class LugarViaje
    {
        public TipoLugar TipoLugar { get; set; }
        public String NombreLugar { get; set; }

        public LugarViaje(int i)
        {
            TipoLugar = new TipoLugar(i);
            NombreLugar = String.Empty;
        }
    }
}
