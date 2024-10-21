using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_Vivo_Metodo_3_Csharp
{
    /* Ejercicio 3:
    Funcion que reciba como parametro un numero entero 
    y muestre un mensaje indicando si el numero es par o impar.
    */
    internal class Program
    {
        static int num;
        static string comprobacion;
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
                        Console.Write("Ingrese el numero: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        if (num % 2 != 0)
                        {
                            comprobacion = Impar();
                            Console.WriteLine(comprobacion);
                            Console.ReadLine();
                            esValido = true;
                        }
                        else
                        {
                            comprobacion = Par();
                            Console.WriteLine(comprobacion);
                            Console.ReadLine();
                            esValido = true;
                        }
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

        static string Par()
        {
            return "El numero es par";
        }

        static string Impar()
        {
            return "El numero es impar";
        }
    }
}