using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_8_Csharp
{
    /* Ejercicio 9:
    2. Crear un programa que introduzca el precio de un articulo y aplique un descuento con la siguiente escala:

        Escala                    Porcentaje
        de 1,000 a 5,000          3%
        de 5,001 a 10,000         5%
        de 10,001 a 15,000        8%
        de 15,001 a 20,000        10%
    */
    internal class Program
    {
        static double precio_Articulo, descuento, precio_Con_Descuento;
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
                        Console.WriteLine("Introduce el precio del articulo: ");
                        precio_Articulo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");

                        if (precio_Articulo >= 1000 && precio_Articulo <= 5000)
                        {
                            descuento = 0.03;
                            precio_Con_Descuento = precio_Articulo - descuento;
                            Console.WriteLine("El precio del articulo con el descuento es de: " + precio_Con_Descuento);
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else if (precio_Articulo > 5000 && precio_Articulo <= 10000)
                        {
                            descuento = 0.05;
                            precio_Con_Descuento = precio_Articulo - descuento;
                            Console.WriteLine("El precio del articulo con el descuento es de: " + precio_Con_Descuento);
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else if (precio_Articulo > 10000 && precio_Articulo <= 15000)
                        {
                            descuento = 0.08;
                            precio_Con_Descuento = precio_Articulo - descuento;
                            Console.WriteLine("El precio del articulo con el descuento es de: " + precio_Con_Descuento);
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else if (precio_Articulo > 15000 && precio_Articulo <= 20000)
                        {
                            descuento = 0.1;
                            precio_Con_Descuento = precio_Articulo - descuento;
                            Console.WriteLine("El precio del articulo con el descuento es de: " + precio_Con_Descuento);
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else
                        {
                            Console.WriteLine("El precio del articulo no entra en el descuento");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ingresa los valores correctos");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                Console.WriteLine("¿Deseas volver a usar el programa? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");
        }
    }
}
