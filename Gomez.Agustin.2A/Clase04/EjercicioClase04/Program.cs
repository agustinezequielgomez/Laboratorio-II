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
            objeto1.EstablecerValor("Khe ase");
            objeto1.EstablecerValor(24);
            objeto1.EstablecerValor(DateTime.Now);
            Console.WriteLine(Cosa.Mostrar(objeto1));

            Cosa objeto2 = new Cosa("Jose");
            objeto2.EstablecerValor("aaaa");
            objeto2.EstablecerValor(558);
            Console.WriteLine(Cosa.Mostrar(objeto2));

            Cosa objeto3 = new Cosa();
            
            Console.WriteLine(Cosa.Mostrar(objeto3));

            Cosa objeto4 = new Cosa("Hola");
            objeto4.EstablecerValor(8888);
            Console.WriteLine(Cosa.Mostrar(objeto4));


            Console.ReadLine();
        }
    }
}
