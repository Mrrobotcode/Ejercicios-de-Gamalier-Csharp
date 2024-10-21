using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_1_Csharp
{
    /* Ejercicio 1:
    Crear un programa que lea n cantidad de números enteros y determine cuantos son 
    positivos, cuantos negativos, cuantos pares, cuantos impares, luego mostrar los 
    resultados en pantalla.
    */
    internal class Program
    {
        static int nCantidadNE, num, numNegativos, numPositivos, numPar, numImpar;
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
                            Console.WriteLine("");
                            esValido = true;
                        }

                        foreach (int num in numerosEnteros)
                        {
                            Console.WriteLine($"Los numeros enteros ingresados son: {num}");
                            esValido = true;
                        }


                        Console.WriteLine("");
                        numNegativos = numerosEnteros.Count(n => n < 0);
                        numPositivos = numerosEnteros.Count(n => n > 0);
                        numPar = numerosEnteros.Count(n => n % 2 == 0);
                        numImpar = numerosEnteros.Count(n => n % 2 != 0);
                        Console.WriteLine($"La cantidad de numeros positivos son: {numPositivos}");
                        Console.WriteLine($"La cantidad de numeros negativos son: {numNegativos}");
                        Console.WriteLine($"La cantidad de numeros pares son: {numPar}");
                        Console.WriteLine($"La cantidad de numeros impares son: {numImpar}");
                        Console.ReadLine();
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