using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_9_Csharp
{
    /* Ejercicio 8:
    Crear un programa que permita introducir la edad y el sexo de una persona, y 
    determine si puede entrar o no a una discoteca, tomando en cuenta lo siguiente: Si es 
    hembra, entra gratis, si es varón, entra pagando, pero no pueden entrar si son menores 
    de edad
    */
    internal class Program
    {
        static char genero;
        static int edad;
        static bool esValido;
        static string pregunta_Volver;
        static void Main(string[] args)
        {
            ComprobacionEdad();
        }

        static void Programa()
        {
            esValido = false;
            while (!esValido)
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("F para Femenino / M para Masculino");
                    genero = Convert.ToChar(Console.ReadLine().ToUpper());
                    Console.WriteLine("");

                    if (genero == 'M')
                    {
                        Console.WriteLine("Puedes entrar, pero debe pagar");
                        Console.ReadLine();
                        Console.Clear();
                        VolveraUsarElPrograma();
                        esValido = true;
                    }
                    else if (genero == 'F')
                    {
                        Console.WriteLine("Puedes entrar gratis");
                        Console.ReadLine();
                        Console.Clear();
                        VolveraUsarElPrograma();
                        esValido = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa los valores correctos");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static void ComprobacionEdad()
        {
            esValido = false;
            while (!esValido)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa tu edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad < 18)
                    {
                        Console.WriteLine("No puedes entrar, eres menor de edad");
                        Console.ReadLine();
                        Console.Clear();
                        VolveraUsarElPrograma();
                    }
                    else
                    {
                        esValido = true;
                        Programa();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingresa los valores correctos");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }

        static void VolveraUsarElPrograma()
        {
            Console.WriteLine("Deseas volver a usar el programa? Si / No");
            pregunta_Volver = Console.ReadLine();

            if (pregunta_Volver == "Si")
            {
                ComprobacionEdad();
            }
        }
    }
}