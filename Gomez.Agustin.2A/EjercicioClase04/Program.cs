using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa objeto1 = new Cosa();
            Console.WriteLine(Cosa.Mostrar(objeto1));

            Cosa objeto2 = new Cosa("Jose");
            Console.WriteLine(Cosa.Mostrar(objeto2));

            Cosa objeto3 = new Cosa();
            objeto3.cadena = "HOla";
            objeto3.numero = 458;
            objeto3.fecha = DateTime.Now;
            Console.Write(Cosa.Mostrar(objeto3));
            Console.ReadLine();
        }
    }
}
