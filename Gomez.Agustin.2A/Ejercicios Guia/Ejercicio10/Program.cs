using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            int cantidadDeFilas = 0;
            int i;
            int j;
            Console.Write("Ingrese la cantidad de filas que tendra su piramide ");
            cantidadDeFilas = int.Parse(Console.ReadLine());
            int aux = cantidadDeFilas;
            for (i = 0; i < cantidadDeFilas; i++)
            {
                for(j=aux;j>0;j--)
                {
                    Console.Write(" ");
                }
                aux--;
                Console.Write("*");
                if (i != 0)
                {
                    for (j = 0; j < i; j++)
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
