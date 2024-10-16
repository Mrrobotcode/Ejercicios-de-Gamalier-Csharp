using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_6_Csharp
{
    /* Ejercicio 6:
    Imprimir los números impares del 1 al 30.
    */
    internal class Program
    {
        static int numImpar;
        static void Main(string[] args)
        {
            for (int i = 1; i <= 30; i++)
            {
                numImpar = i % 2;

                if (numImpar != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
