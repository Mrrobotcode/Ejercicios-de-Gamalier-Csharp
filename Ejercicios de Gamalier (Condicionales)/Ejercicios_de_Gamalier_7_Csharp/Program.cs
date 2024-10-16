using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_7_Csharp
{
    /* Ejercicio 7:
    Introduce el sueldo de un empleado, y aplica un aumento
    mostrar el pantalla, el sueldo anterior y el nuevo sueldo
    */
    internal class Program
    {
        static double sueldo_Anterior, aumento_Sueldo, nuevo_Sueldo;
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
                        Console.WriteLine("Ingresa tu sueldo: ");
                        sueldo_Anterior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        Console.WriteLine("Introduce el porcentaje de tu aumento");
                        aumento_Sueldo = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("");

                        nuevo_Sueldo = nuevo_Sueldo + (sueldo_Anterior * aumento_Sueldo);
                        Console.WriteLine("Tu sueldo actual es de: " + nuevo_Sueldo);
                        Console.ReadLine();
                        Console.Clear();
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.ReadLine();
                    }
                }
              Console.WriteLine("¿Deseas volver a usar el programa de salario nuevo? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");
        }
    }
}