using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            int i;
            int j;
            int numero;
            for (i = 0; i < 10000; i++)
            {
                numero = 0;
                for (j = 1; j < 10000; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        numero += j;
                    }
                }
                if (numero == i)
                {
                    Console.WriteLine("Numero perfecto encontrado: {0}", numero);
                }
            }
            Console.ReadLine();
        }
    }
}
