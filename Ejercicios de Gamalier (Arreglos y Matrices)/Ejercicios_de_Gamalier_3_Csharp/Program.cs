using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_3_Csharp
{
    /* Ejercicio 3:
    Definir un método que reciba como parámetros dos arreglos, uno de tipo string para los
    nombres de los estudiantes y otro de tipo int para las calificaciones. Luego en el 
    Programa principal, debes implementar los arreglos y hacer la llamada al metodo definido
    Los datos deben ser leidos por teclado
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el nombre del estudiante: ");
            string[] estudiante = {Console.ReadLine()};

            Console.Write("Introduce la calificacion del estudiante: ");
            int[] calificaciones = {Convert.ToInt32(Console.ReadLine())};

            Estudiante(estudiante, calificaciones);

        }

        static void Estudiante(string[] estudiante, int[] calificaciones)
        {
            foreach(string estudianteName in estudiante)
            {
                Console.Write($"El nombre del estudiante es: {estudianteName}");
                Console.ReadLine();
            }

            foreach(int calificacionesE in calificaciones)
            {
                Console.Write($"La calificacion del estudiante es: {calificacionesE}");
                Console.ReadLine();
            }
        }
    }
}