using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_17_Csharp
{
    /* Ejercicio 17:
    Crear un programa que permita calcular el ISR (Impuesto Sobre la Renta) 
    de un empleado, partiendo del sueldo de este. Para ello, debe investigar 
    como se realiza el calculo del ISR de este país, también debe investigar la escala impositiva 
    en el sitio web de la DGII, dicha escala es correspondiente a este año en curso. 
    Si el sueldo no aplica para descuento de ISR, mostrar en esa sección un mensaje que diga 
    “No Aplica” o “N/A”. 
    mostrar en pantalla el sueldo, el descuento de AFP y SFS, el ISR y el sueldo neto
    */
    internal class Program
    {
        static double pago_Hora, sueldo_Neto, sueldo_Bruto, descuento, AFP = 2.87, SFS = 3.04, ISR_Anual, ISR_Mensual, ingreso_Anual;
        static int horas_Trabajadas;
        static bool esValido;
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
                        Console.WriteLine("Introduce el pago por hora");
                        pago_Hora = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        Console.WriteLine("Introduce las horas trabajadas");
                        horas_Trabajadas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        esValido = true;

                        sueldo_Bruto = pago_Hora * horas_Trabajadas;
                        descuento = sueldo_Bruto * ((AFP + SFS) / 100);
                        sueldo_Neto = sueldo_Bruto - descuento;
                        ingreso_Anual = sueldo_Neto * 12;

                        if (ingreso_Anual <= 416220)
                        {
                            Console.WriteLine("Tu sueldo bruto es de: " + sueldo_Bruto + "$");
                            Console.WriteLine("Tu descuento de AFP y SFS es de: " + descuento + "$");
                            Console.WriteLine("Tu sueldo neto es de: " + sueldo_Neto + "$");
                            Console.WriteLine("Tu sueldo anual es de: " + ingreso_Anual + "$");
                            Console.WriteLine("No aplica a ISR");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else if (ingreso_Anual > 416220 && ingreso_Anual < 624329)
                        {
                            ISR_Anual = 0.15 * (ingreso_Anual - 416220);
                            ISR_Mensual = ISR_Anual / 12;
                            Console.WriteLine("Tu sueldo bruto es de: " + sueldo_Bruto + "$");
                            Console.WriteLine("Tu descuento de AFP y SFS es de: " + descuento + "$");
                            Console.WriteLine("Tu sueldo neto es de: " + sueldo_Neto + "$");
                            Console.WriteLine("Tu sueldo anual es de: " + ingreso_Anual + "$");
                            Console.WriteLine("Tu ISR mensual es de: " + ISR_Mensual + "$");
                            Console.WriteLine("Tu ISR anual es de: " + ISR_Anual + "$");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else if (ingreso_Anual >= 624329 && ingreso_Anual < 867123)
                        {
                            ISR_Anual = 0.2 * (ingreso_Anual - 624329);
                            ISR_Mensual = ISR_Anual / 12;
                            Console.WriteLine("Tu sueldo bruto es de: " + sueldo_Bruto + "$");
                            Console.WriteLine("Tu descuento de AFP y SFS es de: " + descuento + "$");
                            Console.WriteLine("Tu sueldo neto es de: " + sueldo_Neto + "$");
                            Console.WriteLine("Tu sueldo anual es de: " + ingreso_Anual + "$");
                            Console.WriteLine("Tu ISR mensual es de: " + ISR_Mensual + "$");
                            Console.WriteLine("Tu ISR anual es de: " + ISR_Anual + "$");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                        else if (ingreso_Anual >= 867123)
                        {
                            ISR_Anual = 0.25 * (ingreso_Anual - 624329);
                            ISR_Mensual = ISR_Anual / 12;
                            Console.WriteLine("Tu sueldo bruto es de: " + sueldo_Bruto + "$");
                            Console.WriteLine("Tu descuento de AFP y SFS es de: " + descuento + "$");
                            Console.WriteLine("Tu sueldo neto es de: " + sueldo_Neto + "$");
                            Console.WriteLine("Tu sueldo anual es de: " + ingreso_Anual + "$");
                            Console.WriteLine("Tu ISR mensual es de: " + ISR_Mensual + "$");
                            Console.WriteLine("Tu ISR anual es de: " + ISR_Anual + "$");
                            Console.ReadLine();
                            Console.Clear();
                            esValido = true;
                        }
                    } catch (FormatException)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Debes ingresar valores correctos, intentarlo de nuevo");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                }

              Console.WriteLine("¿Deseas volver a ejecutar el programa? Si / No");
            } while (Console.ReadLine() == "Si");
        }
    }
}