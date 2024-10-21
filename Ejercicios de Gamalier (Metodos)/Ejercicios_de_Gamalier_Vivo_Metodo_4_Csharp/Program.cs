using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_Vivo_Metodo_4_Csharp
{
    /* Ejercicio 4:
    Funcion que reciba por parametro una cantidad en dolares y devuelva
    el resultado en pesos dominicanos.
    */
    internal class Program
    {
        static int cantidadDolares;
        static double dop;
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
                        Console.Write("Introduce la cantidad de dolares: ");
                        cantidadDolares = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        dop = DOP(cantidadDolares);
                        Console.WriteLine($"La cantidad de pesos dominicanos es de: {dop}$");
                        Console.ReadLine();
                        esValido = true;
                    } catch (FormatException)
                    {
                        Console.Write("Introduce valores validos");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }

        static double DOP(double cantidadDolares)
        {
            return cantidadDolares * 60.43;
        }
    }
}
