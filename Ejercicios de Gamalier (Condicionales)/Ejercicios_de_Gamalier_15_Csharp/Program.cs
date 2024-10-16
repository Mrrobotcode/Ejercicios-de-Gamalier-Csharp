using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_15_Csharp
{
    /* Ejercicio 15:
    Pariendo del ejercicio anterior, introduzca un tercer numero y determine cual de los 
    3 es el mayor
    */
    internal class Program
    {
        static double num1, num2, num3;
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

                        Console.WriteLine("Introduce el segundo numero: ");
                        num3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        if (num1 > num2)
                        {
                            Console.WriteLine(num1 + " Es mayor que " + num2 + " y " + num3);
                            Console.ReadLine();
                            esValido = true;
                        }
                        else if (num1 < num2 && num2 > num3)
                        {
                            Console.WriteLine(num2 + " Es mayor que " + num3 + " y " + num1);
                            Console.ReadLine();
                            esValido = true;
                        }
                        else if (num1 < num2 && num2 < num3)
                        {
                            Console.WriteLine(num3 + " Es mayor que " + num2 + " y " + num1);
                            Console.ReadLine();
                            esValido = true;
                        } else
                        {
                            Console.WriteLine("Todos los numeros son iguales");
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
