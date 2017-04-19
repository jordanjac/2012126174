using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012126174
{
    class Program
    {
        static void Main(string[] args)
        {

            var admin = "Jordan";
            var apeAdmin = "Araujo";
            var DNIAdmin = "78945612";
            var sueldoAdmin = 4000m;
            var cargo = "Recepcionista";
            var edadAdmin = 42;

            var trip1 = "Alexander";
            var DNITrip1 = "12345678";
            var edadTrip1 = 25;
            var apeTrip1 = "Camacho";
            var sueldoTrip1 = 1000m;

            var trip2 = "Cesar";
            var DNITrip2 = "23456789";
            var edadTrip2 = 30;
            var apeTrip2 = "Ruiz";
            var sueldoTrip2 = 1000m;

            var cliente1 = "Nick";
            var apeCliente1 = "Jonas";
            var DNIcliente1 = "14789632";

            var cliente2 = "Joe";
            var apeCliente2 = "Jonas";
            var DNIcliente2 = "12369874";

            var cliente3 = "Daddy";
            var apeCliente3 = "Yankee";
            var DNIcliente3 = "65478125";

            var lugar1 = "Lima";
            var lugar2 = "Arequipa";
            var lugar3 = "Piura";

            var placa1 = "FAP-512";
            var placa2 = "PAJ-128";
            var placa3 = "HOL-647";

            var destinatario1 = "Eduardo Gomero";

            var peso1 = 3.6;

            var numerocomprobante1 = 1;
            var numerocomprobante2 = 2;


            Decimal tarifa1 = 20m;
            Decimal tarifa2 = 35m;
            Decimal tarifa3 = 50m;




            /////////////CLIENTE 1
            Cliente Cliente1 = new Cliente();

            Cliente1.DNI = DNIcliente1;
            Cliente1.Nombres = cliente1;
            Cliente1.Apellidos = apeCliente1;

            Tripulacion tripulacion1 = new Tripulacion(DNITrip1, trip1, apeTrip1, 
                                                        edadTrip1, 1, TipoTripulacion.conductor, sueldoTrip1);

            LugarViaje LugarOrigen1 = new LugarViaje(TipoLugar.origen);
            LugarViaje LugarDestino1 = new LugarViaje(TipoLugar.destino);
            LugarOrigen1.NombreLugar = lugar1;
            LugarDestino1.NombreLugar = lugar2;

            Bus Bus1 = new Bus(1);

            Bus1.Placa = placa1;
            Bus1.Tripulacion = tripulacion1;

            Transporte servicio1 = new Transporte(TipoViaje.normal, 1, tripulacion1);

            servicio1.Tarifa = tarifa1;
            servicio1.Origen = LugarOrigen1;
            servicio1.Destino = LugarDestino1;
            servicio1.Cliente = Cliente1;
            servicio1.Bus = Bus1;


            Administrativo Administrativo1 = new Administrativo(DNIAdmin, admin, apeAdmin, edadAdmin, sueldoAdmin);
            Administrativo1.Cargo = cargo;

            Venta venta1 = new Venta(TipoComprobante.boleta, TipoPago.efectivo);


            venta1.Servicio = servicio1;
            venta1.Administrativo = Administrativo1;
            venta1.Cliente = Cliente1;
            venta1.NumeroComprobante = numerocomprobante1;

            Console.WriteLine("\nNúmero de Comprobante : " + venta1.NumeroComprobante +
                "\nEmpleado: " + venta1.Administrativo.Nombres +" " +venta1.Administrativo.Apellidos + " con el cargo de " + venta1.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta1.Servicio.NombreServicio +
                "\nTripulantes: " + servicio1.Bus.Tripulacion.Nombres + " " + servicio1.Bus.Tripulacion.Apellidos + " con el cargo de " + servicio1.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio1.Bus.Placa +
                "\nCategoria del Servicio : " + servicio1.TipoViaje.Viaje +
                "\nMonto: " + venta1.Servicio.Tarifa +
                "\nTipo de Pago: " + venta1.TipoPago.pago +
                "\nLugar de Origen : " + servicio1.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio1.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta1.Cliente.Nombres + " " + venta1.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta1.Cliente.DNI +
                "\nFecha del Servicio: " + venta1.Fecha);


            /////////////CLIENTE 2

            Cliente Cliente2 = new Cliente();

            Cliente2.Nombres = cliente2;
            Cliente2.DNI = DNIcliente2;
            Cliente2.Apellidos = apeCliente2;

            Tripulacion tripulacion2 = new Tripulacion(DNITrip1, trip1, apeTrip1, edadTrip1, 1, TipoTripulacion.conductor, sueldoTrip1) ;

            LugarViaje LugarOrigen2 = new LugarViaje(TipoLugar.origen);
            LugarViaje LugarDestino2 = new LugarViaje(TipoLugar.destino);
            LugarOrigen2.NombreLugar = lugar1;
            LugarDestino2.NombreLugar = lugar2;

            Bus Bus2 = new Bus(1);

            Bus2.Placa = placa2;
            Bus2.Tripulacion = tripulacion2;

            Transporte servicio2 = new Transporte(TipoViaje.vip, 1, tripulacion2);

            servicio2.Tarifa = tarifa2;
            servicio2.Origen = LugarOrigen2;
            servicio2.Destino = LugarDestino2;
            servicio2.Cliente = Cliente2;
            servicio2.Bus = Bus2;


            Administrativo Administrativo2 = new Administrativo(DNIAdmin, admin, apeAdmin, edadAdmin, sueldoAdmin);
            Administrativo2.Cargo = cargo;

            Venta venta2 = new Venta(TipoComprobante.boleta, TipoPago.tarjeta);


            venta2.Servicio = servicio2;
            venta2.Administrativo = Administrativo2;
            venta2.Cliente = Cliente2;
            venta2.NumeroComprobante = numerocomprobante2;

            Console.WriteLine("\nNúmero de Comprobante : " + venta2.NumeroComprobante +
                "\nEmpleado: " + venta2.Administrativo.Nombres + " " + venta2.Administrativo.Apellidos + " " +venta2.Administrativo.Apellidos + " con el cargo de " + venta2.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta2.Servicio.NombreServicio +
                "\nTripulantes: " + servicio2.Bus.Tripulacion.Nombres + " " +servicio2.Bus.Tripulacion.Apellidos + " con el cargo de " + servicio2.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio2.Bus.Placa +
                "\nCategoria del Servicio : " + servicio2.TipoViaje.Viaje +
                "\nMonto: " + venta2.Servicio.Tarifa +
                "\nTipo de Pago: " + venta2.TipoPago.pago +
                "\nLugar de Origen : " + servicio2.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio2.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta2.Cliente.Nombres + " " + venta2.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta2.Cliente.DNI +
                "\nFecha del Servicio: " + venta2.Fecha);

            /////////////CLIENTE 3

            Cliente Cliente3 = new Cliente();

            Cliente3.Nombres = cliente3;
            Cliente3.DNI = DNIcliente3;
            Cliente3.Apellidos = apeCliente3;

            Tripulacion tripulacion3 = new Tripulacion(DNITrip2, trip2, apeTrip2, edadTrip2, 1, TipoTripulacion.conductor, sueldoTrip2);


            LugarViaje LugarOrigen3 = new LugarViaje(TipoLugar.origen);
            LugarViaje LugarDestino3 = new LugarViaje(TipoLugar.destino);
            LugarOrigen3.NombreLugar = lugar2;
            LugarDestino3.NombreLugar = lugar3;

            Bus Bus3 = new Bus(1);

            Bus3.Placa = placa3;
            Bus3.Tripulacion = tripulacion3;

            Encomienda servicio3 = new Encomienda();

            servicio3.Tarifa = tarifa3;
            servicio3.Origen = LugarOrigen3;
            servicio3.Destino = LugarDestino3;
            servicio3.Destinatario = destinatario1;
            servicio3.Peso = peso1;
            servicio3.Bus = Bus3;


            Administrativo Administrativo4 = new Administrativo(DNIAdmin, admin, apeAdmin, edadAdmin, sueldoAdmin);

            Administrativo4.Cargo = cargo;

            Venta venta3 = new Venta(TipoComprobante.boleta, TipoPago.efectivo);


            venta3.Servicio = servicio3;
            venta3.Administrativo = Administrativo4;
            venta3.Cliente = Cliente3;
            venta3.NumeroComprobante = numerocomprobante1;

            Console.WriteLine("\nNúmero de Comprobante : " + venta3.NumeroComprobante +
                "\nEmpleado: " + venta3.Administrativo.Nombres + " " + venta3.Administrativo.Apellidos + " " +venta3.Administrativo.Apellidos + " con el cargo de " + venta3.Administrativo.Cargo +
                "\nTipo de Servicio : " + venta3.Servicio.NombreServicio +
                "\nTripulantes: " + servicio3.Bus.Tripulacion.Nombres + " " + servicio3.Bus.Tripulacion.Apellidos + " con el cargo de " + servicio3.Bus.Tripulacion.TipoTripulacion.Nombre +
                "\nBus con placa : " + servicio3.Bus.Placa +
                "\nMonto: " + venta3.Servicio.Tarifa +
                "\nTipo de Pago: " + venta3.TipoPago.pago +
                "\nLugar de Origen : " + servicio3.Origen.NombreLugar +
                "\nLugar de Destino: " + servicio3.Destino.NombreLugar +
                "\nDatos del Cliente : " + venta3.Cliente.Nombres + " " + venta3.Cliente.Apellidos +
                "\nDNI del Cliente: " + venta3.Cliente.DNI +
                "\nFecha del Servicio: " + venta3.Fecha);


            Console.ReadKey();


        }
    }
}
