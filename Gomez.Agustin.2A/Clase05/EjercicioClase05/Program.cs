using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta pluma1 = new Tinta();
            Tinta pluma2 = new Tinta();
            Console.WriteLine(Tinta.Mostrar(pluma1));
            Console.WriteLine(pluma1 == pluma2);
            Tinta pluma3 = new Tinta(ConsoleColor.Red);
            Console.WriteLine(pluma1 == pluma3);
            Console.WriteLine(pluma1 != pluma3);
            Console.ReadLine();
        }
    }
}
