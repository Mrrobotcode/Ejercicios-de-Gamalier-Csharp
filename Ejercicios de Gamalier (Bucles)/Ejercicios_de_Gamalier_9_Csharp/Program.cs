using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_9_Csharp
{
    /* Ejercicio 9:
    Imprimir un patrón triangular con asteriscos (*) utilizando bucles anidados. Un 
    bucle anidado es aquel que este compuesto de un bucle dentro de otro bucle. Para 
    esto, debe definir el rango en el primer bucle y en el segundo, definir desde 1 hasta la 
    variable del contador del primer bucle.
    */
    internal class Program
    {
        static bool esValido;
        static int filas;
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
                        Console.Write("¿Cuantas filas quieres para el triangulo? ");
                        filas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        for (int i = 1; i <= filas; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        Console.ReadLine();
                        esValido = true;
                    }  catch (FormatException)
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