using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_4_Csharp
{
    /* Ejercicio 4:
    Declarar un arreglo que almacene números leídos por teclado y su la sumatoria es
    Mayor o igual que 100, debe mostrar el resultado en pantalla dicho resultado. Sugerencia
    Para esto se debe utilizar un bucle.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos numeros quieres ingresar: ");
            int[] posiciones = new int[Convert.ToInt32(Console.ReadLine())];
            int[] numeros1 = new int[posiciones.Length];

            for (int i = 0; i < posiciones.Length; i++)
            {
                Console.Write("Ingresa el numero: ");
                numeros1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.Write(numeros1.Sum());
            Console.ReadLine();


            if (numeros1.Sum() >= 100)
            {
                Console.Write("Es mayor o igual a 100");
                Console.ReadLine();
            }
            else
            {
                Console.Write("No es mayor o igual a 100");
                Console.ReadLine();
            }
        }
    }
}