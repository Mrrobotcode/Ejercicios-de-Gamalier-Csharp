using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_Gamalier_3_Csharp
{
    /* Ejercicio 3:
    Crear una clase llamada artículo cuyas propiedades son: 
    nombre, precio, categoría. Luego en la clase principal instanciar la clase con 2 objetos 
    y que pida al usuario leer esos datos para luego, mostrar en pantalla.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo1();
            Articulo2();
        }

        static void Articulo1()
        {
            Articulos articulo1 = new Articulos();
            
            Console.Write("Ingresa el nombre del articulo: ");
            articulo1.nombre = Console.ReadLine();

            Console.Write("Ingresa el precio del articulo: ");
            articulo1.precio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa la categoria del articulo: ");
            articulo1.categoria = Console.ReadLine();

            Console.Write($"El nombre del articulo es: {articulo1.nombre}, el precio del articulo es: {articulo1.precio} y la categoria del articulo es: {articulo1.categoria}");
            Console.ReadLine();
            Console.WriteLine("");
        }

        static void Articulo2()
        {
            Articulos articulo2 = new Articulos();

            Console.Write("Ingresa el nombre del segundo articulo: ");
            articulo2.nombre = Console.ReadLine();

            Console.Write("Ingresa el precio del segundo articulo: ");
            articulo2.precio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa la categoria del segundo articulo: ");
            articulo2.categoria = Console.ReadLine();

            Console.Write($"El nombre del articulo es: {articulo2.nombre}, el precio del articulo es: {articulo2.precio}$ y la categoria del articulo es: {articulo2.categoria}");
            Console.ReadLine();
        }

        public class Articulos
        {
            public string nombre { get; set; }

            public int precio { get; set; }

            public string categoria { get; set; }
        }
    }   }   