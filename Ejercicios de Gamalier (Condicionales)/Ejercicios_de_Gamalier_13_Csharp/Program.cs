using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_13_Csharp
{
    /* Ejercicio 13:
    Crear un programa que permita introducir un numero entero y determine si es par o 
    impar.
    */
    internal class Program
    {
        static double num;
        static bool esValido;
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    esValido = false;
                    while (!esValido)
                    {
                        Console.Clear();
                        Console.WriteLine("Introduce el numero: ");
                        num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        if (num % 2 > 0)
                        {
                            Console.WriteLine("Impar");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else
                        {
                            Console.WriteLine("Par");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introduce los valores correctamente");
                    Console.ReadLine();
                }

                Console.WriteLine("¿Quieres volver a usar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
