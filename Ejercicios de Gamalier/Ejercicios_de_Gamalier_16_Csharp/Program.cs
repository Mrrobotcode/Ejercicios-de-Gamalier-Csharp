using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_16_Csharp
{
    /* Ejercicio 16:
    Partiendo del ejercicio 8, determinar cual es el mayor, cual es el central y cuál es el 
    menor.
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

                        Console.WriteLine("Introduce el tercer numero: ");
                        num3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        if (num1 > num2 && num2 > num3)
                        {
                            Console.WriteLine(num1 + " es el mayor, " + num2 + " es el central y " + num3 + " es el menor ");
                            Console.ReadLine();
                            esValido = true;
                        } else if (num1 > num2 && num2 < num3)
                        {
                            Console.WriteLine(num1 + " es el mayor, " + num3 + " es el central y " + num2 + " es el menor ");
                            Console.ReadLine();
                            esValido = true;
                        }
                        else if (num2 > num1 && num1 > num3)
                        {
                            Console.WriteLine(num2 + " es el mayor, " + num1 + " es el central y " + num3 + " es el menor ");
                            Console.ReadLine();
                            esValido = true;
                        } else if (num2 > num1 && num3 > num1 && num2 > num3)
                        {
                            Console.WriteLine(num2 + " es el mayor, " + num3 + " es el central y " + num1 + " es el menor ");
                            Console.ReadLine();
                            esValido = true;
                        }
                        else if (num3 > num2 && num2 > num1)
                        {
                            Console.WriteLine(num3 + " es el mayor, " + num2 + " es el central y " + num1 + " es el menor ");
                            Console.ReadLine();
                            esValido = true;
                        } else if (num3 > num2 && num1 > num2)
                        {
                            Console.WriteLine(num3 + " es el mayor, " + num1 + " es el central y " + num2 + " es el menor ");
                            Console.ReadLine();
                            esValido = true;
                        }
                        else
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

                Console.Clear();
                Console.WriteLine("¿Quieres volver a usar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
