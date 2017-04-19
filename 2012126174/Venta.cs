﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    public class Venta
    {
   
        public int NumeroComprobante { get; set; }
        public Administrativo Administrativo { get; set; }
        public Cliente Cliente { get; set; }
        public Servicio Servicio { get; set; }
        public TipoPago TipoPago { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public DateTime fecha;


        public DateTime Fecha
        {
            get{return fecha; }
        }
        public Venta(int tipocomprobante, int tipopago)
        {
            Cliente = new Cliente();
            TipoComprobante = new TipoComprobante(tipocomprobante);
            TipoPago = new TipoPago(tipopago);
            fecha = DateTime.Now;
            NumeroComprobante = 0;
        }




    }
}
