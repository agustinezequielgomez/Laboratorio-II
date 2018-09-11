using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase07
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(15, ConsoleColor.Blue, "A");
            Tempera t2 = new Tempera(84, ConsoleColor.DarkGreen, "B");
            Tempera t3 = new Tempera(12, ConsoleColor.Blue, "A");
            string atributos;
            sbyte cantidad;
            cantidad = (sbyte)t2;
            t1 += cantidad;
            atributos = t1;
            Console.WriteLine(atributos);
            t1 += t3;
            atributos = t1;
            Console.WriteLine(atributos);
            Console.ReadLine();
        }
    }
}
