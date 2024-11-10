using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_6_Csharp
{
    /* Ejercicio 6:
    Crear un programa que permita generar un boleto de transporte, tomando en 
    cuenta el costo, tiempo, destino y tipo de transporte. Tome en cuenta que para 
    calcular el precio del boleto, se debe sacar: el tiempo, la distancia y el costo.

    Realizar las operaciones de cálculo 
    de costo, tiempo y distancia, según el 
    tipo de transporte.

                                 Transporte
            Taxi | Metro | Teleférico | Bus Urbano | Bus Interurbano

    Bus interurbano      
    • Línea 
    • Compañía
    
    Teleférico
    • Compañía
    • Línea 
    
    Bus urbano
    • Corredor 
    
    Taxi
    • Destino
    • Distancia

    Metro
    • Compañía             
    • Línea 

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte viaje = new Transporte();
            PrecioBoleto precioBoleto = new PrecioBoleto();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("     Selecciona tu transporte       ");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("  1. Taxi | 2. Metro | 3. Teleférico | 4. Bus Urbano | 5. Bus Interurbano   ");
            Console.WriteLine("----------------------------------------------------------------------------");
            string transporte = Console.ReadLine();

            switch (transporte)
            {
                case "1":
                    Console.WriteLine("                               Destinos                                         "); 
                    Console.WriteLine("--------------------------------------------------------------------------------"); 
                    Console.WriteLine("\n 1. Aeropuerto Internacional de Las Américas (SDQ) a Santo Domingo");
                    Console.WriteLine("\n 2. Hoteles y resorts en Punta Cana y Bavaro"); 
                    Console.WriteLine("\n 3. Centros comerciales en Santo Domingo"); 
                    Console.WriteLine("\n 4. Zonas turísticas en la Ciudad Colonial de Santo Domingo");
                    Console.WriteLine("\n 5. Transporte nocturno en Restaurantes y bares en la Zona Colonial y Piantini \n");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    viaje.destinoViaje = Console.ReadLine();

                    switch (viaje.destinoViaje)
                    {
                        case "1":
                            viaje.costoViaje = 1000;
                            viaje.tiempoViaje = 0.32;
                            viaje.distanciaViaje = 31.6;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Aeropuerto Internacional de Las Américas (SDQ) a Santo Domingo");
                            Console.WriteLine("\n Tiempo de viaje: 32 minutos");
                            Console.WriteLine("\n Distancia de viaje: 31.6Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "2":
                            viaje.costoViaje = 400;
                            viaje.tiempoViaje = 2.40;
                            viaje.distanciaViaje = 209.8;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Hoteles y resorts en Punta Cana y Bavaro");
                            Console.WriteLine("\n Tiempo de viaje: 2 horas y 40 minutos");
                            Console.WriteLine("\n Distancia de viaje: 209.8Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "3":
                            viaje.costoViaje = 300;
                            viaje.tiempoViaje = 0.7;
                            viaje.distanciaViaje = 3.8;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Centros comerciales en Santo Domingo");
                            Console.WriteLine("\n Tiempo de viaje: 7 minutos");
                            Console.WriteLine("\n Distancia de viaje: 3.8Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "4":
                            viaje.costoViaje = 420;
                            viaje.tiempoViaje = 0.1;
                            viaje.distanciaViaje = 2;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Zonas turísticas en la Ciudad Colonial de Santo Domingo");
                            Console.WriteLine("\n Tiempo de viaje: 1 minutos");
                            Console.WriteLine("\n Distancia de viaje: 2Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "5":
                            viaje.costoViaje = 400;
                            viaje.tiempoViaje = 0.3;
                            viaje.distanciaViaje = 0.5;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Zonas turísticas en la Ciudad Colonial de Santo Domingo");
                            Console.WriteLine("\n Tiempo de viaje: 3 minutos");
                            Console.WriteLine("\n Distancia de viaje: 550 Metros");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("                               Destinos                                         ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("\n 1. Centro de los Héroes (La Feria)");
                    Console.WriteLine("\n 2. Villa Mella");
                    Console.WriteLine("\n 3. Centro Olímpico Juan Pablo Duarte");
                    Console.WriteLine("\n 4. Ensanche La Fe y el Malecon \n");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    viaje.destinoViaje = Console.ReadLine();

                    switch (viaje.destinoViaje)
                    {
                        case "1":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.22;
                            viaje.distanciaViaje = 6.3;
                            viaje.lineaViaje = "L1";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Centro de los Héroes (La Feria)");
                            Console.WriteLine("\n Tiempo de viaje: 22 minutos");
                            Console.WriteLine("\n Distancia de viaje: 6.3Km");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "2":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 3.17;
                            viaje.distanciaViaje = 158.2;
                            viaje.lineaViaje = "L2";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Villa Mella");
                            Console.WriteLine("\n Tiempo de viaje: 3 horas y 17 minutos");
                            Console.WriteLine("\n Distancia de viaje: 158.2Km");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "3":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.32;
                            viaje.distanciaViaje = 40;
                            viaje.lineaViaje = "L1";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Centro Olímpico Juan Pablo Duarte");
                            Console.WriteLine("\n Tiempo de viaje: 32 minutos");
                            Console.WriteLine("\n Distancia de viaje: 40Km");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "4":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.44;
                            viaje.distanciaViaje = 51;
                            viaje.lineaViaje = "L1";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Ensanche La Fe y el Malecon");
                            Console.WriteLine("\n Tiempo de viaje: 44 minutos");
                            Console.WriteLine("\n Distancia de viaje: 51Km");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("                               Destinos                                         ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("\n 1. Sabana Perdida");
                    Console.WriteLine("\n 2. Charles de Gaulle");
                    Console.WriteLine("\n 3. Los Tres Brazos");
                    Console.WriteLine("\n 4. Gualey \n");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    viaje.destinoViaje = Console.ReadLine();

                    switch (viaje.destinoViaje)
                    {
                        case "1":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.1;
                            viaje.distanciaViaje = 0.063;
                            viaje.lineaViaje = "T3";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Sabana Perdida");
                            Console.WriteLine("\n Tiempo de viaje: 1 minuto");
                            Console.WriteLine("\n Distancia de viaje: 63 metros");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "2":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.5;
                            viaje.distanciaViaje = 0.10;
                            viaje.lineaViaje = "T4";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Charles de Gaulle");
                            Console.WriteLine("\n Tiempo de viaje: 5 minutos");
                            Console.WriteLine("\n Distancia de viaje: 100 metros");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "3":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.10;
                            viaje.distanciaViaje = 0.20;
                            viaje.lineaViaje = "T2";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Los Tres Brazos");
                            Console.WriteLine("\n Tiempo de viaje: 10 minutos");
                            Console.WriteLine("\n Distancia de viaje: 200 metros");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "4":
                            viaje.costoViaje = 20;
                            viaje.tiempoViaje = 0.8;
                            viaje.distanciaViaje = 0.20;
                            viaje.lineaViaje = "T1";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Gualey");
                            Console.WriteLine("\n Tiempo de viaje: 8 minutos");
                            Console.WriteLine("\n Distancia de viaje: 200 metros");
                            Console.WriteLine($"\n Linea del metro: {viaje.lineaViaje}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case "4":
                    Console.WriteLine("                               Destinos                                         ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("\n 1. Universidades");
                    Console.WriteLine("\n 2. Hospitales públicos y centros de salud");
                    Console.WriteLine("\n 3. Zonas comerciales y mercados");
                    Console.WriteLine("\n 4. Barrios y sectores residenciales \n");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    viaje.destinoViaje = Console.ReadLine();

                    switch (viaje.destinoViaje)
                    {
                        case "1":
                            viaje.costoViaje = 35;
                            viaje.tiempoViaje = 0.45;
                            viaje.distanciaViaje = 15;
                            viaje.corredorBus = "Duarte, 27 de Febrero, John F. Kennedy, Máximo Gómez";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Universidades");
                            Console.WriteLine("\n Tiempo de viaje: 20-45 minutos");
                            Console.WriteLine("\n Distancia de viaje: 5-15Km");
                            Console.WriteLine($"\n Corredores principales: {viaje.corredorBus}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "2":
                            viaje.costoViaje = 35;
                            viaje.tiempoViaje = 0.40;
                            viaje.distanciaViaje = 12;
                            viaje.corredorBus = "27 de Febrero, Independencia, John F. Kennedy, Luperón";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Hospitales públicos y centros de salud");
                            Console.WriteLine("\n Tiempo de viaje: 15-40 minutos");
                            Console.WriteLine("\n Distancia de viaje: 3-12Km");
                            Console.WriteLine($"\n Corredores principales: {viaje.corredorBus}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            break;

                        case "3":
                            viaje.costoViaje = 35;
                            viaje.tiempoViaje = 35;
                            viaje.distanciaViaje = 10;
                            viaje.corredorBus = "Duarte, 27 de Febrero, Churchill, Lincoln, Mella (cerca del Mercado Nuevo y otras áreas comerciales)";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Zonas comerciales y mercados");
                            Console.WriteLine("\n Tiempo de viaje: 10-35 minutos");
                            Console.WriteLine("\n Distancia de viaje: 2-10Km");
                            Console.WriteLine($"\n Corredores principales: {viaje.corredorBus}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            break;

                        case "4":
                            viaje.costoViaje = 35;
                            viaje.tiempoViaje = 50;
                            viaje.distanciaViaje = 20;
                            viaje.corredorBus = "Charles de Gaulle, San Vicente de Paúl, Luperón, John F. Kennedy, Independencia";
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Barrios y sectores residenciales");
                            Console.WriteLine("\n Tiempo de viaje: 15-50 minutos");
                            Console.WriteLine("\n Distancia de viaje: 5-20Km (según el barrio o sector)");
                            Console.WriteLine($"\n Corredores principales: {viaje.corredorBus}");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            break;
                    }
                    break;

                case "5":
                    Console.WriteLine("                               Destinos                                         ");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("\n 1. Santo Domingo a Santiago");
                    Console.WriteLine("\n 2. Santo Domingo a Punta Cana/Bavaro");
                    Console.WriteLine("\n 3. Santo Domingo a San Pedro de Macoris y La Romana");
                    Console.WriteLine("\n 4. Santo Domingo a Puerto Plata");
                    Console.WriteLine("\n 5. Santo Domingo a Barahona \n");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    viaje.destinoViaje = Console.ReadLine();
                    Console.WriteLine("");

                    switch (viaje.destinoViaje)
                    {
                        case "1":
                            viaje.costoViaje = 700;
                            viaje.tiempoViaje = 2.24;
                            viaje.distanciaViaje = 155.9;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Santo Domingo a Santiago");
                            Console.WriteLine("\n Tiempo de viaje: 2 horas y 24 minutos");
                            Console.WriteLine("\n Distancia de viaje: 155.9Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "2":
                            viaje.costoViaje = 800;
                            viaje.tiempoViaje = 2.21;
                            viaje.distanciaViaje = 196.8;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("--------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Santo Domingo a Punta Cana/Bavaro");
                            Console.WriteLine("\n Tiempo de viaje: 2 horas y 21 minutos");
                            Console.WriteLine("\n Distancia de viaje: 196.8Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("---------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "3":
                            viaje.costoViaje = 300;
                            viaje.tiempoViaje = 1.6;
                            viaje.distanciaViaje = 77.2;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Santo Domingo a San Pedro de Macoris y La Romana");
                            Console.WriteLine("\n Tiempo de viaje: 1 hora y 6 minutos");
                            Console.WriteLine("\n Distancia de viaje: 77.2Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "4":
                            viaje.costoViaje = 800;
                            viaje.tiempoViaje = 3.22;
                            viaje.distanciaViaje = 208.9;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Santo Domingo a Puerto Plata");
                            Console.WriteLine("\n Tiempo de viaje: 3 horas y 22 minutos");
                            Console.WriteLine("\n Distancia de viaje: 208.9Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;

                        case "5":
                            viaje.costoViaje = 500;
                            viaje.tiempoViaje = 2.50;
                            viaje.distanciaViaje = 181.7;
                            Console.WriteLine("                Boleto                   ");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            Console.WriteLine("\n Destino: Santo Domingo a Barahona");
                            Console.WriteLine("\n Tiempo de viaje: 2 horas y 50 minutos");
                            Console.WriteLine("\n Distancia de viaje: 181.7Km");
                            Console.WriteLine($"\n Precio: {precioBoleto.precioBoleto(viaje.costoViaje, viaje.tiempoViaje, viaje.distanciaViaje)}$RD \n");
                            Console.WriteLine("------------------------------------------------------------------------------");
                            Console.ReadLine();
                            break;
                    }
                    break;
            }
        }

        public class Transporte
        {
            public double tiempoViaje { get; set; }

            public double distanciaViaje { get; set; }

            public double costoViaje { get; set; }

            public string destinoViaje { get; set; }

            public string lineaViaje { get; set; }

            public string corredorBus { get; set; }
        }

        public class PrecioBoleto : Transporte
        {
            public double precioBoleto(double tiempoViaje, double distanciaViaje, double costoViaje)
            {
                return tiempoViaje + distanciaViaje + costoViaje;
            }
        }
    }
}