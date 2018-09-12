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
            Kelvin k = new Kelvin(1);
            Farenheit f1 = new Farenheit(1);
            Celsius c2 = new Celsius(1);
            /*c1 = (Celsius) k;
            f1 = (Farenheit) c1;*/
            //c1 = (Celsius)k;
            f1 += k;
            Console.WriteLine(f1.getCantidad());
            f1 += k;
            Console.WriteLine(f1.getCantidad());
            Console.ReadLine();
        }
    }
}
