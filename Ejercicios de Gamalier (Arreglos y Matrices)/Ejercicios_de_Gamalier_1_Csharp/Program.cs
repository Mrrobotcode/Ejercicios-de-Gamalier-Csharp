using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_1_Csharp
{
    /* Ejercicio 1:
    
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros1 = new int[10];
            int[] numeros2 = new int[10];

            for (int i = 0; i < numeros1.Length; i++)
            {
                Console.Write("Ingresa el numero: ");
                numeros1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            for (int j = 0; j < numeros2.Length; j++)
            {
                Console.Write("Ingresa el numero: ");
                numeros2[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            int[] totalArray = { numeros1.Sum() + numeros2.Sum()};

            foreach (int resultado in totalArray)
            {
                Console.Write($"El resultado de la suma es: {resultado}");
                Console.ReadLine();
            }
            
        }
    }
}