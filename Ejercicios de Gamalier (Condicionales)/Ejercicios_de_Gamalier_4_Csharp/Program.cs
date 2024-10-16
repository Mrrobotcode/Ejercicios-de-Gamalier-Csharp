using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_4_Csharp
{
    /* Ejercicio 4:
    Leer 5 números por teclado y calcular el 
    promedio, luego imprimir el resultado. 
    Para obtener el promedio, se realiza 
    sumando las cantidades y luego se 
    divide entre ellas
    */
    internal class Program
    {
        static double num1, num2, num3, num4, num5, promedio;
        static bool esValido;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("            Bienvenido a Mr.RobotCodeAVGCalculator            ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("");

                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        Console.WriteLine("Ingresa el primer valor:");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingresa el segundo valor");
                        num2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingresa el tercer valor");
                        num3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingresa el cuarto valor");
                        num4 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Ingresa el quinto valor");
                        num5 = Convert.ToDouble(Console.ReadLine());
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.WriteLine("");
                    }

                    Console.WriteLine("");
                    promedio = (num1 + num2 + num3 + num4 + num5) / 5;
                    Console.WriteLine("El promedio de los 5 numeros son: " + promedio);
                    Console.ReadLine();
                    Console.Clear();
                }
              Console.WriteLine("¿Deseas volver a usar la calculadora de promedio? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");

        }
    }
}
