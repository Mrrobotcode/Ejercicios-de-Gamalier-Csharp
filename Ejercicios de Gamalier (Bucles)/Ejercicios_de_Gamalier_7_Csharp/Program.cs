using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_7_Csharp
{
    /* Ejercicio 7:
    Realizar la tabla de multiplicar de un numero especifico del 1 al 12, por ejemplo: 
    “2 x 3 = 6”, imprimir la tabla en pantalla.
    */
    internal class Program
    {
        static int num;
        static bool esValido;
        static string elegir;
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
                        Console.WriteLine("----------------------------------------------------------------");
                        Console.WriteLine("Escoge E para ver una tabla de multiplicar especifica \nT para ver todas las tablas");
                        Console.WriteLine("----------------------------------------------------------------");
                        elegir = Console.ReadLine();
                        esValido = true;

                        switch (elegir)
                        {
                            case "E":
                                Console.Write("Introduce la tabla de multiplicar que quieres ver: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                esValido = true;

                                for (int i = 1; i <= 12; i++)
                                {
                                    Console.WriteLine(num + "X" + i + "=" + (num * i));
                                    esValido = true;
                                }
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case "T":
                                for (int i = 1; i <= 12; i++)
                                {
                                    for (int j = 1; j <= 12; j++)
                                    {
                                        Console.WriteLine(i + "X" + j + "=" + (i * j));
                                        Console.WriteLine("");
                                        esValido = true;
                                    }
                                }
                                Console.ReadLine();
                                esValido = true;
                                break;

                            default:
                                Console.WriteLine("Ingresa valores validos");
                                Console.Read();
                                esValido = true;
                                break;
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