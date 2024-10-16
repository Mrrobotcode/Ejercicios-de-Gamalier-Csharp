using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_12_Csharp
{
    /* Ejercicio 12:
    Crear un programa que permita introducir un numero entero y determine si es 
    positivo o negativo
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
                        Console.Clear();
                        esValido = true;

                        if (num < 0)
                        {
                            Console.WriteLine("El numero es negativo");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else if (num >= 0)
                        {
                            Console.WriteLine("El numero es positivo");
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
                    Console.Clear();
                }

                Console.WriteLine("¿Quieres volver a usar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}