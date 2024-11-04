using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_5_Csharp
{
    /* Ejercicio 5:
    Crear un programa que permita realizar operaciones básicas usando herencia
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeros numero1 = new Numeros();
            Numeros numero2 = new Numeros();
            Suma sumar = new Suma();
            Resta restar = new Resta();
            Multiplicacion multiplicar = new Multiplicacion();

            Console.Write("Ingresa el primer numero: ");
            numero1.num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el primer numero: ");
            numero2.num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Elige tu operacion: \n 1 Suma | 2 Resta | 3 Multiplicacion");
            int operacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            switch (operacion)
            {
                case 1:
                    Console.Write($"El resultado de tu suma es: {sumar.Sumar(numero1.num1, numero2.num2)}");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write($"El resultado de tu suma es: {restar.Restar(numero1.num1, numero2.num2)}");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write($"El resultado de tu suma es: {multiplicar.Multiplicar(numero1.num1, numero2.num2)}");
                    Console.ReadLine();
                    break;
            }

        }

        public class Numeros
        {
            public double num1 { get; set; }
            public double num2 { get; set; }
        }

        public class Suma : Numeros
        {
            public double Sumar(double num1, double num2)
            {
                return num1 + num2;
            }
        }

        public class Resta : Numeros
        {
            public double Restar(double num1, double num2)
            {
                return num1 - num2;
            }
        }

        public class Multiplicacion : Numeros
        {
            public double Multiplicar(double num1, double num2)
            {
                return num1 * num2;
            }
        }

    }
}
