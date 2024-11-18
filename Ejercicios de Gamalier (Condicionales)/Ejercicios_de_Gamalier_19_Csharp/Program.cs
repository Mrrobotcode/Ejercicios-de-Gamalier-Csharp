using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_19_Csharp
{
    /* Ejercicio 19:
    Crear un programa que introduzca el sueldo de un empleado y aplicar un incentivo 
    si tiene hijos y aplicar 500 por cada hijo que tenga. Mostrar en pantalla el sueldo, 
    numero de hijos y el incentivo correspondiente, siempre y cuando tenga hijos
    */
    internal class Program
    {
        static bool esValido;
        static int incentivo, hijos_Empleado;
        static double sueldo_Empleado, sueldoTotal;
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

                        Console.WriteLine("Introduce tu sueldo neto: ");
                        sueldo_Empleado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la cantidad de hijos que tengas: ");
                        hijos_Empleado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        if (hijos_Empleado > 0)
                        {
                            incentivo = hijos_Empleado * 500;
                            sueldoTotal = incentivo + sueldo_Empleado;
                            Console.Write($"El sueldo total es: {sueldoTotal}$");
                            Console.ReadLine();
                        } else
                        {
                            Console.Write("No aplicas al incentivo");
                            Console.ReadLine();
                        }
                    } catch (FormatException)
                    {
                        Console.WriteLine("Introduce los valores correctos");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
