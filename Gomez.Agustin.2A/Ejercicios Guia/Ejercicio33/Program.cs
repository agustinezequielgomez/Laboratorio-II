using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Hola que tal";
            libro[1] = "Como estas";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Nueva pag";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
            Console.ReadLine();
        }
    }
}

