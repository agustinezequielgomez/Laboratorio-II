using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius c1 = new Celsius(1d);
            Kelvin k = new Kelvin(278.15);
            Farenheit f1 = new Farenheit(5);
            Celsius c2 = new Celsius(0);
            /*c1 = (Celsius) k;
            f1 = (Farenheit) c1;*/
            //c1 = (Celsius)k;
            c2 = (Celsius)f1;
            Console.WriteLine(c2.getCantidad());
            c1 += f1;
            Console.WriteLine(c1.getCantidad());
            Console.ReadLine();
        }
    }
}
