using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;
            do
            {
                Console.Write("Ingrese Numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Error, reingrese: ");
                }
                suma += numero;
                Console.Write("Total actual: " + suma);



                Console.WriteLine("¿Continua? (S/N) ");
            } while (ValidarRespuesta.ValidaS_N());
        }
    }
}
