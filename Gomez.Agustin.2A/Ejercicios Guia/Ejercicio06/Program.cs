using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            int año;
            Console.Write("Ingrese un año ");
            año = int.Parse(Console.ReadLine());
            if (año%4==0&&año%100!=0||año%400==0)
            {
                Console.WriteLine("El año {0} es bisiesto",año);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El año {0} no es bisiesto", año);
                Console.ReadLine();
            }
            
        }
    }
}
