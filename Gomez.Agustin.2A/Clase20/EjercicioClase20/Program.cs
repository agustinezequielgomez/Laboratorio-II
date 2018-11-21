using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace EjercicioClase20
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Alberto", "Gomez", 45, ESexo.Masculino);
            Console.WriteLine("Nombre: {0}",persona.Nombre);
            Console.WriteLine("Apellido: {0}",persona.Apellido);
            Console.WriteLine("Edad: {0}",persona.Edad);
            Console.WriteLine("Sexo: {0}",persona.Sexo);
            Console.WriteLine(persona.ObtenerDatos());

            PersonaExternaHeredada personaExterna = new PersonaExternaHeredada("AAA", "BBB", 67, Entidades.Externa.ESexo.Indefinido);
            Console.WriteLine(personaExterna.ObtenerDatos());

            PersonaExternaSellada sellada = new PersonaExternaSellada("BBB", "CCC", 447, Entidades.Externa.Sellada.ESexo.Masculino);
            Console.WriteLine(sellada.ObtenerDatos());

            Console.WriteLine(sellada.EsNulo());

            PersonaExternaSellada sellada2 = null;
            Console.WriteLine(sellada2.EsNulo() + "\n");

            Console.WriteLine((4445).CantidadDigitos());
            Console.WriteLine((1111155584).CantidadDigitos() + "\n");

            Console.WriteLine((348).TieneLaMismaCantidad(5) + "\n");
            Console.ReadKey();
            Console.Clear();


            Persona personaDB1 = new Persona("AAA", "BBB", 15, ESexo.Masculino);
            Persona personaDB2 = new Persona("CCC", "DDD", 27, ESexo.Femenino);

            personaDB1.AgregarDB();
            personaDB2.AgregarDB();

            Persona personaDB3 = new Persona("EEE", "FFF", 77, ESexo.Indeterminado);

            personaDB3.ModificarDB(7);

            personaDB3.QuitarDB(46);
            personaDB3.QuitarDB(43);
            personaDB3.QuitarDB(40);
            personaDB3.QuitarDB(37);
            personaDB3.QuitarDB(34);
            personaDB3.QuitarDB(31);
            personaDB3.QuitarDB(28);
            personaDB3.QuitarDB(49);
            personaDB3.QuitarDB(52);

            List<Persona> l = persona.TraerDB();
            foreach (Persona item in l)
            {
                Console.WriteLine(item.ObtenerDatos());
            }

            Console.ReadKey();
        }
    }
}
