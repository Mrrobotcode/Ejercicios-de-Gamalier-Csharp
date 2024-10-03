using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_2_Csharp
{
    /* Ejercicio 2: 
    Crear un programa que permita calcular 
    el sueldo neto de un empleado, 
    partiendo del pago por hora y las horas 
    trabajadas, aplicar un descuento de AFP (Administradoras de Fondos de Pensiones) 
    que es 2.87% y SFS (Seguro Familiar de Salud) que es el 
    3.04%, sumar los descuentos y luego 
    debe restarlos del sueldo bruto
    */
    internal class Program
    {
        static double pago_Hora, sueldo_Neto, sueldo_Bruto, descuento, AFP = 2.87, SFS = 3.04;
        static int horas_Trabajadas;
        static bool esValido;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("            Bienvenido a Mr.RobotCodeSalaryCalculator         ");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("");

                esValido = false;
                while (!esValido)
                {
                    try
                    {
                        Console.WriteLine("Ingresa tu pago por hora: ");
                        pago_Hora = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");

                        Console.WriteLine("Ingresa las horas trabajadas: ");
                        horas_Trabajadas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.WriteLine("");
                    }
                }

                sueldo_Bruto = pago_Hora * horas_Trabajadas;
                descuento = sueldo_Bruto * ((AFP + SFS) / 100);
                sueldo_Neto = sueldo_Bruto - descuento;

                Console.WriteLine("Tu sueldo bruto es de: " + sueldo_Bruto + "$");
                Console.WriteLine("Tu descuento es de: " + descuento + "$");
                Console.WriteLine("Tu sueldo neto es de: " + sueldo_Neto + "$");
                Console.ReadLine();
                Console.Clear();
              
              Console.WriteLine("¿Deseas volver a usar la calculadora de salario? (si / no)");
            } while (Console.ReadLine().ToLower() == "si");

        }
    }
}