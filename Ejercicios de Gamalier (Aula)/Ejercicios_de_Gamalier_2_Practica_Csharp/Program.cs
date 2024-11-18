using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicios_de_Gamalier_2_Practica_Csharp.Program;

namespace Ejercicios_de_Gamalier_2_Practica_Csharp
{
    /* Ejercicio 2 (Practica):
     * README ME:
     
     * Nombre:
     
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante();
            RegistroAcademico metodos = new RegistroAcademico();
            Asignatura asignaturas = new Asignatura();
            double p1, p2, p3;


            Console.Write("Ingresa tu nombre: ");
            estudiante1.NombreEstudiante = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            estudiante1.EdadEstudiante = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingresa el nombre de la primera asignatura: ");
            asignaturas.NombreAsignatura1 = Console.ReadLine();

            Console.Write("Ingresa el nombre de la segunda asignatura: ");
            asignaturas.NombreAsignatura2 = Console.ReadLine();

            Console.Write("Ingresa el nombre de la tercera asignatura: ");
            asignaturas.NombreAsignatura3 = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Ingresa la calificacion de la primera asignatura: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificacion de la segunda asignatura: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificacion de la tercera asignatura: ");
            p3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            asignaturas.Calificacion = (p1 + p2 + p3) / 3;

            metodos.MostrarRegistro(estudiante1.NombreEstudiante, estudiante1.EdadEstudiante, asignaturas.NombreAsignatura1, asignaturas.NombreAsignatura2, asignaturas.NombreAsignatura3, asignaturas.Calificacion);

            Console.Clear();
            OtroEstudiante();
        }

        static void OtroEstudiante()
        {
            Estudiante estudiante2 = new Estudiante();
            RegistroAcademico metodos = new RegistroAcademico();
            Asignatura asignaturas = new Asignatura();
            double p1, p2, p3;


            Console.Write("Ingresa tu nombre: ");
            estudiante2.NombreEstudiante = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            estudiante2.EdadEstudiante = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el nombre de la primera asignatura: ");
            asignaturas.NombreAsignatura1 = Console.ReadLine();

            Console.Write("Ingresa el nombre de la segunda asignatura: ");
            asignaturas.NombreAsignatura2 = Console.ReadLine();

            Console.Write("Ingresa el nombre de la tercera asignatura: ");
            asignaturas.NombreAsignatura3 = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Ingresa la calificacion de la primera asignatura: ");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificacion de la segunda asignatura: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa la calificacion de la tercera asignatura: ");
            p3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            asignaturas.Calificacion = (p1 + p2 + p3) / 3;

            metodos.MostrarRegistro(estudiante2.NombreEstudiante, estudiante2.EdadEstudiante, asignaturas.NombreAsignatura1, asignaturas.NombreAsignatura2, asignaturas.NombreAsignatura3, asignaturas.Calificacion);
        }

        public class Estudiante
        {
            public string NombreEstudiante { get; set; }

            public int EdadEstudiante { get; set; }
        }

        public class Asignatura : Estudiante
        {
            public string NombreAsignatura1 { get; set; }

            public string NombreAsignatura2 { get; set; }

            public string NombreAsignatura3 { get; set; }

            public double Calificacion { get; set; }
        }

        public class RegistroAcademico : Asignatura
        {

            public void AgregarAsignatura()
            {
                
            }

            public void CalcularPromedio()
            {
                
            }

            public void MostrarRegistro(string NombreEstudiante, int EdadEstudiante, string NombreAsignatura1, string NombreAsignatura2, string NombreAsignatura3, double Calificacion)
            {

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine($"El nombre del estudiante es: {NombreEstudiante}");
                    Console.WriteLine($"La edad del estudiante es: {EdadEstudiante}");
                    Console.WriteLine($"Las asignaturas del estudiante {NombreEstudiante} son {NombreAsignatura1 + " , " + NombreAsignatura2 + ", " + NombreAsignatura3}");
                    Console.WriteLine($"El promedio de calificacion del estudiante es {Calificacion}");
                }
                Console.ReadLine();
            }

            
        }
    }
}
