using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio57
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Jose", "Alberto");
            Persona persona2;
            Persona.Guardar(persona);

            persona2 = Persona.Leer();
            Console.WriteLine(persona2.ToString());

            Console.ReadKey();
        }
    }
}
