using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PP_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Grupo g1 = new Grupo("LA MANADA PIOLA", Grupo.TipoManada.Unica);
            Perro p1 = new Perro("PEPE", "CALLEJERO");
            Perro p2 = new Perro("JOSELE","PITBULL",16,true);
            Gato ga1 = new Gato("Garfield", "Come Lasagna");
            Gato ga2 = new Gato("asdasd", "Egipcio");
            Gato ga3 = new Gato("asdasd", "Egipcio");
            g1 += p1;
            g1 += p2;
            g1 += ga1;
            g1 += ga2;
            g1 += ga3;
            g1 += p1;
            cadena = g1;
            Console.WriteLine(cadena);
            Console.ReadLine();
                
        }
    }
}
