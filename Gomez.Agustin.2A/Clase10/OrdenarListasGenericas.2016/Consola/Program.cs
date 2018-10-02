using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Libreria;
using OtraLibreria;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();

            Persona p1 = new Persona("Pérez", "Ricardo", 123);
            Persona p2 = new Persona("Álvarez", "Zulema", 789);
            Persona p3 = new Persona("Fernandez", "Hugo", 456);
            Persona p4 = new Persona("Otero", "Andrés", 951);

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(p4);

            Console.WriteLine("Lista NO ordenada");
            Console.WriteLine(Persona.MostrarLista(lista));

            Console.WriteLine("Lista ordenada sólo por apellido");
            lista.Sort(Persona.OredenaPersonasPorApellido);
            Console.WriteLine(Persona.MostrarLista(lista));

            Console.WriteLine("Lista ordenada sólo por dni");
            lista.Sort(Persona.OredenaPersonasPorDni);
            Console.WriteLine(Persona.MostrarLista(lista));

            Console.WriteLine("Lista ordenada sólo por nombre");
            lista.Sort(Persona.OredenaPersonasPorNombre);
            Console.WriteLine(Persona.MostrarLista(lista));


            Ordenador ordena = new Ordenador();

            Console.WriteLine("Lista ordenada sólo por dni, con método de instancia de otra clase");
            lista.Sort(ordena.OrdenarPersonasPorDni);
            Console.WriteLine(Persona.MostrarLista(lista));


            Console.ReadLine();
        }
    }
}
