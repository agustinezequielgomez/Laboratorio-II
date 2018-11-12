using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio59
{
    class Program
    {
        static void Main(string[] args)
        {
            Local local = new Local("111", 15, "222", 1);
            local.RutaDeArchivo = "Local.xml";
            local.Guardar();
            Local local2 = local.Leer();
            local2.RutaDeArchivo = "Local.xml";
            Console.WriteLine(local2.ToString());
            Console.ReadKey();
            Console.Clear();
            Provincial provincial = new Provincial("111", Provincial.Franja.Franja_1, 1, "222");
            provincial.RutaDeArchivo = "Provincial.xml";
            provincial.Guardar();
            Provincial provincial2 = provincial.Leer();
            Console.WriteLine(provincial2.ToString());
            Console.ReadKey();
           
        }
    }
}
