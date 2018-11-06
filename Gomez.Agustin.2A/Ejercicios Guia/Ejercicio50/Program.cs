using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class Program
    {
        static void Main(string[] args)
        {
            GuardarTexto<int, string> guardarTexto = new GuardarTexto<int, string>();
            Console.WriteLine(guardarTexto.Guardar(2));
            Console.WriteLine(guardarTexto.Leer());

            Serializar<int, string> serializar = new Serializar<int, string>();
            Console.WriteLine(serializar.Guardar(2));
            Console.WriteLine(serializar.Leer());
            Console.ReadKey();
        }
    }
}
