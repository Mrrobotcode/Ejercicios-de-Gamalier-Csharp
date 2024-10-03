using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_5_Csharp
{
    /* Ejercicio 5:
    Leer la cantidad y precio de un artículo y 
    calcular su importe, mostrar el resultado 
    en pantalla
    */
    internal class Program
    {
        static double precio_Articulo, importe;
        static int cantidad_Articulo;
        static bool esValido;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("          Bienvenido a Mr.RobotCodeAmountCalculator           ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("");
                
                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        Console.WriteLine("Ingresa la cantidad de los articulos: ");
                        cantidad_Articulo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingresa el precio del articulo: ");
                        precio_Articulo = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        importe = cantidad_Articulo * precio_Articulo;
                        Console.WriteLine("El importe del articulo es de: " + importe + "$");
                        Console.ReadLine();
                        Console.Clear();
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.WriteLine("");
                    }
                }
              Console.WriteLine("¿Deseas volver a usar la calculadora de importe? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");
        }
    }
}
