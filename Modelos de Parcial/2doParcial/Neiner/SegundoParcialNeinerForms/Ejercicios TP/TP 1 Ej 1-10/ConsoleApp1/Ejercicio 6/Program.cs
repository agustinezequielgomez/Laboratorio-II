using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            int ano;
            
            Console.Write("Ingrese ano: ");
            while (!int.TryParse(Console.ReadLine(), out ano))
            {
                Console.Write("Error, reingrese: ");
            }
            if ((ano%4==0 && ano%100!=0) || ano%100==0 && ano%400==0)
            {
                Console.WriteLine("Es un año bisiesto");
            }
            else
            {
                Console.WriteLine("No es un año bisiesto");
            }
            
            Console.Read();
        }
    }
}
