using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_1_Csharp
{
    /* Ejercicio 1
    Hacer una calculadora basica en la consola, que se pueda sumar, restar,
    multiplicar y dividir. Dependiendo de la seleccion del usuario.
    
    PD: Implemente manejo de errores para la calculadora, 
    estadistica de operaciones basado en el usuario y 
    una funcion que permitar volver a usar la calculadora, 
    solo si el usuario quiere.
    */
    internal class Program
    {
        static double valor1, valor2, resultado;
        static int operacion, contador_Sumar = 0, contador_Restar = 0, contador_Multi = 0, contador_Division = 0;
        static bool esValido;

        static void Main(string[] args) 
        {
            Calculadora();
            Estadisticas();
        } 

        static void Calculadora()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("                Bienvenido a Mr.RobotCodeCalculator           ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("");

                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        Console.WriteLine("Ingresa el primer valor:");
                        valor1 = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("");
                        
                        Console.WriteLine("Ingresa el segundo valor");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.WriteLine("");
                    }
                }

                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("\n Selecciona una operacion \n \n 1 Para sumar \n 2 para restar \n 3 para multiplicacion \n 4 para division \n");
                Console.WriteLine("--------------------------------------------------------------");
                operacion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (operacion)
                {
                    case 1:
                        contador_Sumar++;
                        resultado = valor1 + valor2;
                        Console.WriteLine($"El resultado de tu suma es: {resultado}");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        contador_Restar++;
                        resultado = valor1 - valor2;
                        Console.WriteLine($"El resultado de tu restar es: {resultado}");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        contador_Multi++;
                        resultado = valor1 * valor2;
                        Console.WriteLine($"El resultado de tu multiplicacion es: {resultado}");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        if (valor2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por cero");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            contador_Division++;
                            resultado = valor1 / valor2;
                            Console.WriteLine($"El resultado de tu dividion es: {resultado}");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }
             
              Console.WriteLine("¿Deseas volver a usar la calculadora? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");
        }

        static void Estadisticas()
        {
         Console.Clear();
         Console.WriteLine("--------------------------------------------------------------");
         Console.WriteLine("\n Estadisticas: \n \n Hiciste: " + contador_Sumar + " operaciones de sumar \n Hiciste: " + contador_Restar + " operaciones de restar \n Hiciste: " + contador_Multi + " operaciones de multiplicacion \n Hiciste: " + contador_Division + " operaciones de division \n Gracias por usar mi calculadora, vuelve pronto \n");
         Console.WriteLine("--------------------------------------------------------------");
         Console.ReadLine();
        }
    }
}