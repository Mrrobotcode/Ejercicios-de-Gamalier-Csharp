using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_4_Csharp
{
    /* Ejercicios 4:
    Crear una clase llamada Estudiante que contenga las siguientes propiedades: 
    matricula, nombre, edad, carrera. Luego debe crear en la clase principal un array de objetos 
    de 5 estudiantes que le permita ingresar esos datos y permita mostrar en pantalla.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiantes[] estudiante = new Estudiantes[5];

            for (int i = 0; i < estudiante.Length; i++)
            {
                estudiante[i] = new Estudiantes();

                Console.Write("Ingresa el nombre del estudiante: ");
                estudiante[i].Nombre = Console.ReadLine();

                Console.Write("Ingresa la edad del estudiante: ");
                estudiante[i].Edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresa la carrera del estudiante: ");
                estudiante[i].Carrera = Console.ReadLine();

                Console.Write("Ingresa la matricula del estudiante: ");
                estudiante[i].Matricula = Console.ReadLine();

                Console.WriteLine();
            }

            for (int i = 0; i < estudiante.Length; i++)
            {
                Console.WriteLine($"El nombre del estudiante es: {estudiante[i].Nombre}");
                Console.WriteLine($"La edad del estudiante es: {estudiante[i].Edad}");
                Console.WriteLine($"La carrera del estudiante es: {estudiante[i].Carrera}");
                Console.WriteLine($"La matricula del estudiante es: {estudiante[i].Matricula}");
                Console.ReadLine();
            }
        }

        class Estudiantes
        {
            public string Nombre { get; set; }

            public int Edad { get; set; }

            public string Carrera { get; set; }

            public string Matricula { get; set; }
        }
        
    }
}
