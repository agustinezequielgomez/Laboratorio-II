using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador objeto = new Sumador(14);
            Console.WriteLine(objeto.Sumar("15","6"));
            Sumador objeto2 = new Sumador(14);
            Console.WriteLine(objeto2.Sumar(14L, 76L));
            Console.WriteLine(objeto | objeto2);
            Console.ReadLine();
        }
    }
}
