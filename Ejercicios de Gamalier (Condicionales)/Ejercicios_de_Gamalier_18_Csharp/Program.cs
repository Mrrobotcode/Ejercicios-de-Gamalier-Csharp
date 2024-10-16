using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_18_Csharp
{
    /* Ejercicio 18:
    Crear un programa que permita determinar si le corresponde incentivos a un 
    empleado, tomando en cuenta la producción semanal que se realiza desde el lunes 
    hasta el viernes, cada día se debe registrar la producción y obtener el promedio de 
    esta, si el promedio es mayor o igual a 20,000 unidades, le corresponde un incentivo de 
    3,000 pesos, de lo contrario, colocar un mensaje que indica “N/A”. Mostrar en pantalla 
    el total de la producción de la semana, el promedio de la producción y el incentivo que 
    corresponde
    */
    internal class Program
    {
        static bool esValido;
        static double produccion_Semanal, produccion_Lunes, produccion_Martes, produccion_Miercoles, produccion_Jueves, produccion_Viernes, promedio_Produccion;
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
                        Console.WriteLine("Introduce la produccion del Lunes");
                        produccion_Lunes = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la produccion del Martes");
                        produccion_Martes = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la produccion del Miercoles");
                        produccion_Miercoles = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la produccion del Jueves");
                        produccion_Jueves = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la produccion del Viernes");
                        produccion_Viernes = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        produccion_Semanal = produccion_Lunes + produccion_Martes + produccion_Miercoles + produccion_Jueves + produccion_Viernes;
                        promedio_Produccion = produccion_Semanal / 5;

                        if (promedio_Produccion >= 20000)
                        {
                            Console.WriteLine("El total de la produccion semanal es de: " + produccion_Semanal);
                            Console.WriteLine("El promedio de la produccion semanal es de: " + promedio_Produccion);
                            Console.WriteLine("Al empleado se le corresponde un incentivo de 3,000$");
                            Console.ReadLine();
                            esValido = true;
                        } else
                        {
                            Console.WriteLine("El total de la produccion semanal es de: " + produccion_Semanal);
                            Console.WriteLine("El promedio de la produccion semanal es de: " + promedio_Produccion);
                            Console.WriteLine("N/A");
                            Console.ReadLine();
                            esValido = true;
                        }
                    } catch (FormatException)
                    {
                        Console.WriteLine("Introduca los valores correctos");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
