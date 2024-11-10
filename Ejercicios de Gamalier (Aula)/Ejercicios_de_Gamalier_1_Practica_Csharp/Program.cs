using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_1_Practica_Csharp
{
    /* Ejercicio 1 (Practica):
     * README
    
    Nombre: Jose Genuel Mercedes Abreu
    Numero: 18
    Modulo: Desarrollo de Aplicaciones Informaticas
    Practica: Sistema de reserva de cine

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] cine = new char[10, 10];
            CrearCine(cine);

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                MostrarCine(cine);

                Console.Write("Ingrese el numero de fila (1-10): ");
                int fila = Convert.ToInt32(Console.ReadLine()) - 1;
                
                Console.Write("Ingrese el numero de columna (1-10): ");
                int columna = Convert.ToInt32(Console.ReadLine()) - 1;

                if (fila >= 0 && fila < 10 && columna >= 0 && columna < 10)
                {
                    if (cine[fila, columna] == 'L')
                    {
                        cine[fila, columna] = 'X';
                        Console.WriteLine("Asiento reservado");
                    }
                    else
                    {
                        Console.WriteLine("El asiento ya esta ocupado. Elija otro");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada incorrecta. Favor seleccionar del 1 al 10");
                }

                Console.Write("¿Desea reservar otro asiento? (S/N): ");
                continuar = Console.ReadLine() == "S";
            }

            Console.WriteLine("Gracias por usar el sistema de reservas de asientos");
        }

        static void CrearCine(char[,] cine)
        {
            for (int i = 0; i < cine.GetLength(0); i++)
            {
                for (int j = 0; j < cine.GetLength(1); j++)
                {
                    cine[i, j] = 'L';
                }
            }
        }

        static void MostrarCine(char[,] cine)
        {
            Console.WriteLine("Mapa de asientos (L = Libre, X = Ocupado): ");
            Console.WriteLine("");

            for (int i = 0; i < cine.GetLength(0); i++)
            {
                for (int j = 0; j < cine.GetLength(1); j++)
                {
                    Console.Write(cine[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }
} 