using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sobrecarga_Constructores
{
    class SobrecargaConstructoresTest
    {
        static void Main(string[] args)
        {
            Persona primeraPersona = new Persona();
            Persona segundaPersona = new Persona("Lopez");
            Persona terceraPersona = new Persona("Rodriguez", "Luis");
            Persona cuartaPersona = new Persona(22999000, "Ana", "Perez");
            Persona quintaPersona = new Persona("Fernandez", "Hugo", 21666888);

            primeraPersona.MostrarPersona();
            segundaPersona.MostrarPersona();
            terceraPersona.MostrarPersona();
            cuartaPersona.MostrarPersona();
            quintaPersona.MostrarPersona();

        }
    }
}
