using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";
            int tamano;
            int contador;
            string asterisco="*";
            Console.Write("Ingrese tamano: ");
            while (!int.TryParse(Console.ReadLine(), out tamano) || tamano < 1)
            {
                Console.Write("Error, reingrese: ");
            }

            for (contador=0;contador<tamano;contador++ )
            {
                Console.WriteLine(asterisco);
                asterisco += "**";
            }
            Console.Read();
        }
    }
}
