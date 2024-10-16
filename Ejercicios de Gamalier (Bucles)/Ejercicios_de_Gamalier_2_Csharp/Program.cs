using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_2_Csharp
{
    /* Ejercicio 2:
    Crear un programa que lea una contraseña, si es incorrecta, mostrar un mensaje 
    que lo indique y tenga como máximo 3 intentos, luego después de esos intentos, 
    mostrar un mensaje indicando que ha agotado el numero de intentos y el programa 
    debe terminar.
    */
    internal class Program
    {
        static string passwordUsuario, passwordSistema;
        static int intentos;
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
                        intentos = 3;
                        passwordSistema = "Admin2024";
                        Console.Write("Introduce la contraseseña: ");
                        passwordUsuario = Console.ReadLine();
                        Console.WriteLine("");
                        esValido = true;

                        if (passwordSistema != passwordUsuario)
                        {
                            if (passwordSistema != passwordUsuario)
                            {
                                for (int i = 2; i < 3; i++)
                                {
                                    Console.WriteLine($"Te queda {i} intentos");
                                }
                                Console.Write("Introduce la contraseseña: ");
                                passwordUsuario = Console.ReadLine();
                                Console.WriteLine("");
                                esValido = true;

                                if (passwordSistema == passwordUsuario)
                                {
                                    Console.WriteLine("Contraseña correcta. Puedes entrar");
                                    Console.ReadLine();
                                    esValido = true;
                                }
                                else
                                {
                                    for (int i = 1; i < 2; i++)
                                    {
                                        Console.WriteLine($"Te queda {i} intentos");
                                    }
                                    Console.Write("Introduce la contraseseña: ");
                                    passwordUsuario = Console.ReadLine();
                                    Console.WriteLine("");
                                    esValido = true;

                                    if (passwordSistema == passwordUsuario)
                                    {
                                        Console.WriteLine("Contraseña correcta. Puedes entrar");
                                        Console.ReadLine();
                                        esValido = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Contraseña incorrecta. No tienes mas intentos");
                                        Console.ReadLine();
                                        esValido = true;
                                    }
                                }
                            }
                        } else
                        {
                            Console.WriteLine("Contraseña correcta. Puedes entrar");
                            Console.ReadLine();
                            esValido = true;
                        }
                    }
                } catch (FormatException)
                {
                    Console.WriteLine("Introduce valores validos");
                    Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("¿Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}