using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace RPP_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            DirectorTecnico dt = new DirectorTecnico("Natan", "Sinay");
            Equipo e1 = new Equipo("Sacachispas FC",dt);
            Jugador j1 = new Jugador("Natan", "Sinay", 10, true);
            Jugador j2 = new Jugador("Julian", "Estarque", 9, false);
            Jugador j3 = new Jugador("Alejandro", "Lezano", 7, false);
            Jugador j4 = new Jugador("Ezequiel", "Jimenez", 5, false);
            Jugador j5 = new Jugador("Emanuel", "Quispe");
            Jugador j6 = new Jugador("Matias", "Velazco", 13, false);
            e1 += j1;
            e1 += j2;
            e1 += j3;
            e1 += j4;
            e1 += j5;
            e1 += j6;
            cadena = e1;
            Console.WriteLine(cadena);
            Console.ReadLine();
        }
    }
}
