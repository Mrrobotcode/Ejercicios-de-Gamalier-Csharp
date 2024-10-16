using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_4_Csharp
{
    /* Ejercicio 4:
    Calcular la suma de los primeros 100 numeros naturales.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i * (i + 1) / 2);
            }
            Console.ReadLine();
        }
    }
}