using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_3_Csharp
{
    /* Ejercicio 3:
    Crear un programa que lea n cantidad de números enteros, si la sumatoria es mayor 
    o igual a 100, el programa debe mostrar un mensaje indicando que la sumatoria es 
    mayor o igual a 100.
    */
    internal class Program
    {
        static int nCantidadNE, num, sumatoria;
        static List<int> numerosEnteros = new List<int>();
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
                        numerosEnteros.Clear();
                        Console.Clear();
                        Console.Write("Introduce la cantidad de numeros enteros: ");
                        nCantidadNE = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        for (int i = 0; i < nCantidadNE; i++)
                        {
                            Console.Write($"Ingrese el numero {i + 1}: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            numerosEnteros.Add(num);
                            esValido = true;
                        }

                        sumatoria = numerosEnteros.Sum(i => i);

                        if (sumatoria >= 100)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("La sumatoria es mayor o igual a 100");
                            Console.ReadLine();
                            esValido = true;
                        } else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("La sumatoria no es mayor o igual a 100");
                            Console.ReadLine();
                            esValido = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Introduce valores validos");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.Clear();
                Console.WriteLine("Quieres volver a ejecutar el programar? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
