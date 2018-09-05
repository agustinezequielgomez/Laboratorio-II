using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase06
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta = new Tinta(ConsoleColor.Blue, ETipoTinta.comun);
            Pluma pluma1 = new Pluma("Parker", 0, tinta);
            Console.WriteLine(pluma1);
            Tinta tinta2 = new Tinta();
            Console.WriteLine(pluma1 == tinta);
            pluma1 += tinta;
            Console.WriteLine(pluma1);
            pluma1 -= tinta;
            Console.WriteLine(pluma1);
            Pluma mala = new Pluma();
            Console.WriteLine(mala == tinta);
            Console.ReadLine();
        }
    }
}
