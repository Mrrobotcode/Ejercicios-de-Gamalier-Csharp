using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_5_Csharp
{
    /* Ejercicio 5:
    Calcular el promedio de los primeros 100 numeros natuales.
    */
    internal class Program
    {
        static double promedio;
        static int sumatoria;
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                sumatoria = i * (i + 1) / 2;
                promedio = sumatoria / 100;
            }
            Console.WriteLine(promedio);
            Console.ReadLine();
        }
    }
}
