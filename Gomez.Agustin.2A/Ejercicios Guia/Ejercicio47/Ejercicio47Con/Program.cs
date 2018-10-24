using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47Lib;

namespace Ejercicio47Con
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 09, 5);
            EquipoFutbol equipoFutbol4 = new EquipoFutbol("Saca", dateTime);
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("Saca", dateTime);
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("ASDASD", DateTime.Now);

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Sanl", DateTime.Now);
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("PEPEPE", DateTime.Now);
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Test", DateTime.Now);

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("20 Giles tras una pelota");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("LLEGO CARLOS, LLEGO CARLOS, EL NEGRO QUE SABE JUGAR BASKETBALL");

            torneoFutbol += equipoFutbol4;
            torneoFutbol += equipoFutbol2;
            torneoFutbol += equipoFutbol3;

            Console.WriteLine(torneoFutbol.Mostrar());

            torneoBasquet += equipoBasquet1;
            torneoBasquet += equipoBasquet2;
            torneoBasquet += equipoBasquet3;

            Console.WriteLine(torneoBasquet.Mostrar());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.ReadKey();

        }
    }
}
