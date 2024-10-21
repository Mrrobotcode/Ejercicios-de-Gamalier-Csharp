using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_Vivo_Metodo_1_Csharp
{
    /* Ejercicio 1:
    Funcion que devuelva la suma de dos numeros.
    */
    internal class Program
    {
        static int num1, num2, resultado;
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
                        Console.Clear();
                        Console.Write("Ingrese el primer valor: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.Write("Ingrese el segundo valor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        resultado = Sum(num1, num2);
                        Console.WriteLine($"El resultado de tu suma {resultado}");
                        Console.ReadLine();
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.Write("Introduce valores validos");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
