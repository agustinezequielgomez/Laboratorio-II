using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo equipo = new Equipo(5, "ALTO EQUIPO");
            Jugador j1 = new Jugador(42147544, "Agustin");
            Jugador j2 = new Jugador(42147545, "Ezequiel");
            Jugador j3 = new Jugador(42147546, "Martin",8,2);
            Jugador j4 = new Jugador(42147547, "Roberto", 0, 2);
            Jugador j5 = new Jugador(42147544, "Alfonos");
            Jugador j6 = new Jugador(42147589, "Paasdas");

            equipo += j1;
            equipo += j2;
            equipo += j3;
            equipo += j4;
            equipo += j5;
            equipo += j6;

            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(j3.MostrarDatos());
            j3.GetPromedioGoles();
            Console.WriteLine(j3.MostrarDatos());
            Console.ReadLine();
        }
    }
}
