using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Perla_y_Gamalier_2_Csharp
{
    /* Ejercicio 2 (Perla):
    Usa la gerencia para poder crear un animal y a ese animal darle un metodo de sonido, 
    y que gerende los atributos de la clase base (Animal)
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro();
            Gato();
        }

        static void Perro()
        {
            Dog perro = new Dog();
            
            Console.Write("Introduce el nombre del perro: ");
            perro.nombre = Console.ReadLine();

            Console.Write("Introduce la edad del perro: ");
            perro.edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la raza del perro: ");
            perro.raza = Console.ReadLine();

            Console.Write($"El nombre del perro es: {perro.nombre}, la edad del perro es: {perro.edad}, la raza del perro es: {perro.raza}");
            Console.WriteLine("");
            perro.MakeSound();
        }

        static void Gato()
        {
            Cat gato = new Cat();

            Console.Write("Introduce el nombre del gato: ");
            gato.nombre = Console.ReadLine();

            Console.Write("Introduce la edad del gato: ");
            gato.edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce la raza del gato: ");
            gato.raza = Console.ReadLine();

            Console.Write($"El nombre del gato es: {gato.nombre}, la edad del gato es: {gato.edad}, la raza del gato es: {gato.raza}");
            Console.WriteLine("");
            gato.MakeSound();
            Console.ReadLine();
        }

        public class Animal
        {
            public string nombre { get; set; }

            public int edad { get; set; }

            public string raza { get; set; }
        }

        public class Dog : Animal
        {
            public void MakeSound()
            {
                Console.Write("Wuaf!");
                Console.WriteLine("");
            }
        }

        public class Cat : Animal
        {
            public void MakeSound()
            {
                Console.Write("Miau!");
                Console.WriteLine("");
            }
        }
    }
}