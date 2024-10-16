using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_11_Csharp
{
    /* Ejercicio 11:
       Partiendo del ejercicio anterior, determinar el literal según la calificación obtenida 
       del estudiante:
        
        Calificación Situación
        90 – 100 Excelente
        80 – 89 Muy bueno
        75 – 79 Bueno
        70 – 74 Regular
        Menos de 70 deficiente
    */
    internal class Program
    {
        static double p1, p2, p3, p4, promedio;
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
                        Console.WriteLine("Introduce la nota del P1");
                        p1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P2");
                        p2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P3");
                        p3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P4");
                        p4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        promedio = (p1 + p2 + p3 + p4) / 4;
                        Console.WriteLine("El promedio de las notas es de: " + promedio);
                        Console.ReadLine();
                        Console.Clear();
                        esValido = true;

                        if (promedio >= 70)
                        {
                            Console.WriteLine("Aprobo");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else
                        {
                            Console.WriteLine("No aprobo");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }

                        if (promedio > 90 && promedio <= 100)
                        {
                            Console.WriteLine("Excelente");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else if (promedio >= 80 && promedio < 90)
                        {
                            Console.WriteLine("Muy bueno");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else if (promedio >= 75 && promedio < 80)
                        {
                            Console.WriteLine("Bueno");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else if (promedio >= 70 && promedio < 75)
                        {
                            Console.WriteLine("Regular");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else 
                        {
                            Console.WriteLine("Deficiente");
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
