using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";
            int cantidadDeFilas = 0;
            int i;
            int j;
            Console.Write("Ingrese la cantidad de filas que tendra su piramide ");
            cantidadDeFilas = int.Parse(Console.ReadLine());
            for(i=0;i<cantidadDeFilas;i++)
            {
                Console.Write("*");
                if (i!=0)
                {
                    for(j=0;j<i;j++)
                    {
                        Console.Write("**");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
