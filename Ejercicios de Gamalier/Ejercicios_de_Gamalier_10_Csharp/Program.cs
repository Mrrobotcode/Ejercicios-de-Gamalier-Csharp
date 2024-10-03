using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_10_Csharp
{
    /* Ejercicio 10:
    Calcular el promedio de las 4 notas de un estudiante y determinar si aprobó o 
    reprobó, sabiendo que, para aprobar, la nota mínima es 70 puntos. Mostrar en 
    pantalla el promedio de las calificaciones y el mensaje que indique si aprobó o reprobó.
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
                    }
                } catch (FormatException)
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
