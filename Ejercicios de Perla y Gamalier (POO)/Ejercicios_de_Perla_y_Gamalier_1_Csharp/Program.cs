using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Perla_y_Gamalier_1_Csharp
{
    /* Ejercicio 1 (Perla):
    Crear una clase Dispositivo y a esa clase darle los atributos de: tipo, color y marca y 
    darle uno o dos metodos, y ejecutarlo en el Main 
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispositivo dispositivo = new Dispositivo();

            Console.Write("Introduce el tipo de dispositivo: ");
            dispositivo.tipo = Console.ReadLine();

            Console.Write("Introduce el color del dispositivo: ");
            dispositivo.color = Console.ReadLine();

            Console.Write("Introduce la marca del dispositivo: ");
            dispositivo.marca = Console.ReadLine();

            Console.Write($"El tipo de dispositivo es: {dispositivo.tipo}, el color del dispositivo es: {dispositivo.color}, la marca del dispositivo es: {dispositivo.marca}");
            Console.WriteLine("");
            dispositivo.buscaNopor();
            Console.WriteLine("");
        }
    }
}
