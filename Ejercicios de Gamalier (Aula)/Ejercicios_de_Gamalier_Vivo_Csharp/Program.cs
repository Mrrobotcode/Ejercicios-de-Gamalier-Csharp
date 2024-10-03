using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_Vivo_Csharp
{
    /* Prueba de Fuego (En Vivo):
    Crear un programa que calcule el promedio de las 4 notas de un estudiante, 
    determine si aprobó o reprobó, tomando en cuenta que para aprobar la nota mínima es 70 puntos, 
    si reprobó, entonces el estudiante ira a completivo, para esto se calcula el 50% de la nota promedio, 
    colocar la nota del examen o prueba y de este también se calcula el 50%, 
    el resultado de la nota completiva 
    es sumando los resultados de los 50%. 
    Si aprueba, debe mostrar en pantalla la nota y determinar si aprobó o reprobó la parte completiva. 
    Si reprobó, entonces el estudiante ira a extraordinario, donde se calculará el 30% de la nota promedio, 
    se introduce la nota de la prueba extraordinaria y calcular el 70% de dicha nota. 
    El resultado de la calificación extraordinaria es sumando el resultado del 30% y del 70%. 
    Si el estudiante aprobó, se debe mostrar en pantalla que aprobó, colocando la nota y el mensaje, 
    de lo contrario reprobó.  Mostrar en pantalla el nombre, la materia, la calificación obtenida, 
    ya sea normal, completivo o extraordinario y la situación si aprobó o reprobó.
    */
    internal class Program
    {
        static double p1, p2, p3, p4, promedio, completivo, prueba, promedio_prueba, extraordinario, nota_Completiva, nota_Extraordinario;
        static string nombre_Persona, materia;
        static bool esValido;
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    esValido = false;
                    while (!esValido)
                    {
                        Console.Clear();
                        Console.WriteLine("Introduce tu nombre: ");
                        nombre_Persona = Console.ReadLine();
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce el nombre de la materia: ");
                        materia = Console.ReadLine();
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P1");
                        p1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P2");
                        p2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P3");
                        p3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la nota del P4");
                        p4 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        promedio = (p1 + p2 + p3 + p4) / 4;
                        completivo = 0.5 * promedio;
                        extraordinario = 0.3 * promedio;
                        Console.WriteLine("El promedio de las notas es de: " + promedio);
                        Console.ReadLine();
                        Console.Clear();
                        esValido = true;

                        if (promedio >= 70)
                        {
                            Console.WriteLine("Aprobo");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        } else
                        {
                            Console.WriteLine("Iras a completivo");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;

                            Console.WriteLine("Introduce la nota del examen de completivo: ");
                            prueba = Convert.ToDouble(Console.ReadLine());
                            promedio_prueba = 0.5 * prueba;
                            Console.WriteLine("");
                            esValido = true;

                            nota_Completiva = completivo + promedio_prueba;

                            if (nota_Completiva >= 70)
                            {
                                Console.WriteLine("Aprobo");
                                Console.WriteLine("Tu resultado de tu nota de Completivo es de: " + nota_Completiva);
                                Console.WriteLine("Tu nombre es: " + nombre_Persona);
                                Console.WriteLine("La materia es: " + materia);
                                Console.ReadLine();
                                Console.Clear();
                                esValido = true;
                            } else
                            {
                                Console.WriteLine("Iras a extraordinario");
                                Console.ReadLine();

                                Console.WriteLine("Introduce la nota del examen de extraordinario: ");
                                prueba = Convert.ToDouble(Console.ReadLine());
                                promedio_prueba = 0.7 * prueba;
                                Console.WriteLine("");
                                esValido = true;

                                nota_Extraordinario = extraordinario + promedio_prueba;

                                if (nota_Extraordinario >= 70)
                                {
                                    Console.WriteLine("Aprobo");
                                    Console.WriteLine("Tu nombre es: " + nombre_Persona);
                                    Console.WriteLine("La materia es: " + materia);
                                    Console.WriteLine("Tu resultado de tu nota de extraordinario es de: " + nota_Extraordinario);
                                    Console.ReadLine();
                                    Console.Clear();
                                    esValido = true;
                                } else
                                {
                                    Console.WriteLine("Te quemaste");
                                    Console.WriteLine("Tu nombre es: " + nombre_Persona);
                                    Console.WriteLine("La materia es: " + materia);
                                    Console.WriteLine("El resultado de tu nota de Extraordinario es de: " + nota_Extraordinario);
                                    Console.ReadLine();
                                    Console.Clear();
                                    esValido = true;
                                }
                            }
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introduce los valores correctamente");
                    Console.ReadLine();
                    Console.Clear();
                }

                Console.WriteLine("¿Quieres volver a usar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}