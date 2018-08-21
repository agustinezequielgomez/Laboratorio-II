using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio00
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            Console.Write("Ingrese su nombre: ");
            nombre=Console.ReadLine();
            Console.WriteLine("Su nombre es {0}", nombre);
            Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Su nombre es {0} y su edad es {1}", nombre, edad);
            Console.WriteLine("La fecha de hoy es {0:dddd dd \\de MMMM \\de yyyy \\y \\son la\\s HH:mm:ss tt}", DateTime.Now);
            Console.ReadLine();  
        }
    }
}