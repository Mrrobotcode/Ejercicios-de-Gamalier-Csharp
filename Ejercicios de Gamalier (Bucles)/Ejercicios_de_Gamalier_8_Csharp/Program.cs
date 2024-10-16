using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_8_Csharp
{
    /* Ejercicio 8:
    Calcular los números ingresados por el usuario hasta que ingrese un cero (0). 
    Mostrar en pantalla el resultado de la sumatoria.
    */
    internal class Program
    {
        static bool esValido;
        static List<int> numerosEnteros = new List<int>();
        static int num, nCantidadNE, sumatoria;
        static void Main(string[] args)
        {
            do
            {
                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        do
                        {
                            numerosEnteros.Clear();
                            Console.Clear();
                            Console.Write("Introduce la cantidad de numeros enteros que quieres sumar: ");
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
                        } while (num != 0);

                        Console.WriteLine("");
                        sumatoria = numerosEnteros.Sum(i => i);
                        Console.WriteLine($"La sumatoria de los numero es de: {sumatoria}");
                        Console.ReadLine();
                        esValido = true;
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