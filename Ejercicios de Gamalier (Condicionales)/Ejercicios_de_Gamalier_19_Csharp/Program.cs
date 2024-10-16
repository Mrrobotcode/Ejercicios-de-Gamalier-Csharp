using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_19_Csharp
{
    /* Ejercicio 19:
    Crear un programa que introduzca el sueldo de un empleado y aplicar un incentivo 
    si tiene hijos y aplicar 500 por cada hijo que tenga. Mostrar en pantalla el sueldo, 
    numero de hijos y el incentivo correspondiente, siempre y cuando tenga hijos
    */
    internal class Program
    {
        static bool esValido;
        static double sueldo_Empleado, hijos_Empleado;
        static void Main(string[] args)
        {
            do
            {
                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        Console.Clear();

                        Console.WriteLine("Introduce tu sueldo neto: ");
                        sueldo_Empleado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce la cantidad de hijos que tengas: ");
                        hijos_Empleado = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        switch (hijos_Empleado)
                        {
                            case 1:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 2:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 1000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 3:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 1500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 4:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 2000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 5:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 2500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 6:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 3000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 7:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 3500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 8:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 4000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 9:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 4500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 10:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 5000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 11:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 5500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 12:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 6000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 13:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 6500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 14:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 7000$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            case 15:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("Tu incetivo es de 7500$");
                                Console.ReadLine();
                                esValido = true;
                                break;

                            default:
                                Console.WriteLine("Tu suedo neto es de: " + sueldo_Empleado);
                                Console.WriteLine("La cantidad de numeros de hijos que tienes es de: " + hijos_Empleado);
                                Console.WriteLine("No tienes incetivo");
                                Console.ReadLine();
                                esValido = true;
                                break;
                        }


                    } catch (FormatException)
                    {
                        Console.WriteLine("Introduce los valores correctos");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}
