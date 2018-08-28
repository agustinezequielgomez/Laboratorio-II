using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "1";
            Console.Write(Sello.Imprimir());
            Console.ReadLine();
        }
    }
}
