using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_14_Csharp
{
    /* Ejericio 14:
    Crear un programa que permita introducir 2 numeros enteros y determine cual de 
    los dos es mayor
    */
    internal class Program
    {
        static double num1, num2;
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
                        Console.WriteLine("Introduce el primer numero: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce el segundo numero: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        if (num1 > num2)
                        {
                            Console.WriteLine(num1 + " Es mayor que " + num2);
                            Console.ReadLine();
                            esValido = true;
                        } else if (num1 < num2)
                        {
                            Console.WriteLine(num2 + " Es mayor que " + num1);
                            Console.ReadLine();
                            esValido = true;
                        } else
                        {
                            Console.WriteLine("Ambos numeros son iguales");
                            Console.ReadLine();
                            esValido = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Introduce los valores correctamente");
                    Console.ReadLine();
                }

                Console.WriteLine("¿Quieres volver a usar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
