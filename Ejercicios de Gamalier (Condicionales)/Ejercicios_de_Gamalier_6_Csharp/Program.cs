using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Gamalier_6_Csharp
{
    /* Ejercicio 6:
    Crear un programa que calcule la cantidad y precio de un articulo, luego calcular el
    impuesto del ITBIS que es el 18%, aplicar un descuento de 10%, y calcular el total
    general. El ITBIS se calcula multiplicando el importe por el 18%, el descuento se calcula
    multiplicando el importe por el 10% y total general se calcula restando el importe menos descuento mas ITBIS
    */
    internal class Program
    {
        static int cantidad_Articulo;
        static double precio_Articulo, ITBIS = 18, importe, descuento = 10, total_General;
        static bool esValido;
        static void Main(string[] args)
        {
            do
            {
                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Ingresa la cantidad de articulos: ");
                        cantidad_Articulo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingresa el precio del articulo: ");
                        precio_Articulo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");

                        importe = cantidad_Articulo * precio_Articulo;
                        ITBIS = importe * (ITBIS / 100);
                        descuento = importe * (descuento / 100);
                        total_General = (importe - descuento) + ITBIS;

                        Console.WriteLine("El importe es de " + importe + "$");
                        Console.WriteLine("El ITBIS es de: " + ITBIS + "$");
                        Console.WriteLine("El descuento es de " + descuento + "$");
                        Console.WriteLine("El total general es: " + total_General + "$");
                        Console.ReadLine();
                        Console.Clear();
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.ReadLine();
                    }
                }
              Console.WriteLine("¿Deseas volver a usar el programa de total general de un articulo? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");
        }
    }
}