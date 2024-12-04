using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_2_Practica_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.Clear();
                Console.WriteLine($"Ingreso de datos para el estudiante {i}");
                RegistrarEstudiante();
            }
        }

        static void RegistrarEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            Asignatura asignaturas = new Asignatura();

            Console.Write("Ingresa tu nombre: ");
            estudiante.NombreEstudiante = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            estudiante.EdadEstudiante = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el nombre de la primera asignatura: ");
            asignaturas.NombreAsignatura1 = Console.ReadLine();

            Console.Write("Ingresa el nombre de la segunda asignatura: ");
            asignaturas.NombreAsignatura2 = Console.ReadLine();

            Console.Write("Ingresa el nombre de la tercera asignatura: ");
            asignaturas.NombreAsignatura3 = Console.ReadLine();

            Console.Write("Ingresa la calificación de la primera asignatura: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificación de la segunda asignatura: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificación de la tercera asignatura: ");
            double p3 = Convert.ToDouble(Console.ReadLine());

            asignaturas.Calificacion = (p1 + p2 + p3) / 3;

            MostrarRegistro(estudiante, asignaturas);
        }

        static void MostrarRegistro(Estudiante estudiante, Asignatura asignaturas)
        {
            Console.WriteLine("\nRegistro del Estudiante:");
            Console.WriteLine($"Nombre: {estudiante.NombreEstudiante}");
            Console.WriteLine($"Edad: {estudiante.EdadEstudiante}");
            Console.WriteLine($"Asignaturas: {asignaturas.NombreAsignatura1}, {asignaturas.NombreAsignatura2}, {asignaturas.NombreAsignatura3}");
            Console.WriteLine($"Promedio: {asignaturas.Calificacion:F2}");
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }

        public class Estudiante
        {
            public string NombreEstudiante { get; set; }
            public int EdadEstudiante { get; set; }
        }

        public class Asignatura
        {
            public string NombreAsignatura1 { get; set; }
            public string NombreAsignatura2 { get; set; }
            public string NombreAsignatura3 { get; set; }
            public double Calificacion { get; set; }
        }
    }
}