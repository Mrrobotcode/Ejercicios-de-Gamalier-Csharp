using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_2_Csharp
{
    /* Ejercicio 2:
    Una tienda de electrónica tiene una matriz que representa el inventario de distintos 
    tipos de Dispositivos (televisores, laptops, teléfonos, etc.) en varios almacenes. 
    Cada fila represena un tipo de dispositivo y cada columna un almacén.

    Calcula la cantitad total de dispositivos en cada almacén.
    Determina qué dispositivo tiene mayor y menos cantidad en cada almacén.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dispositivos = { "Televisores", "Laptops", "Telefonos" };
            string[] almacenes = { "Almacen", "Almacen", "Almacen" };

            int[,] inventario = new int[dispositivos.Length, almacenes.Length];

            inventario[0, 0] = 10;
            inventario[0, 2] = 12;
            inventario[1, 0] = 20;
            inventario[1, 1] = 7;
            inventario[1, 2] = 15;
            inventario[2, 0] = 25;
            inventario[2, 1] = 30;
            inventario[2, 2] = 18;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| Dispositivo | Almacen | Almacen | Almacen |");
            Console.WriteLine("---------------------------------------------");
            for (int i = 0; i < dispositivos.Length; i++)
            {
                Console.Write($"| " + dispositivos[i].PadRight(12) + "| ");
                for (int j = 0; j < almacenes.Length; j++)
                {
                    Console.Write(inventario[i, j].ToString().PadRight(8) + "| ");
                }
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
            }
            Console.WriteLine("");

            for (int j = 0; j < almacenes.Length; j++)
            {
                int totalPorAlmacen = 0; 
                
                for (int i = 0; i < dispositivos.Length; i++) 
                { 
                    totalPorAlmacen += inventario[i, j]; 
                }

                Console.WriteLine($"Total en almacen: {totalPorAlmacen}");
            }
            
            Console.WriteLine("");
            
            for (int j = 0; j < almacenes.Length; j++) 
            { 
                int maxCantidad = int.MinValue; 
                int minCantidad = int.MaxValue; 
                string dispositivoMax = ""; 
                string dispositivoMin = ""; 
                
                for (int i = 0; i < dispositivos.Length; i++) 
                { 
                    if (inventario[i, j] > maxCantidad) 
                    { 
                        maxCantidad = inventario[i, j]; dispositivoMax = dispositivos[i]; 
                    } 
                    
                    if (inventario[i, j] < minCantidad) 
                    { 
                        minCantidad = inventario[i, j]; dispositivoMin = dispositivos[i]; 
                    } 
                } 
                Console.WriteLine("En almacen: "); 
                Console.WriteLine(" Mayor cantidad: " + dispositivoMax + " (" + maxCantidad + ")"); 
                Console.WriteLine(" Menor cantidad: " + dispositivoMin + " (" + minCantidad + ")");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}