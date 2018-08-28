using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            string dibujo;
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            if(boligrafoAzul.Pintar(20, out dibujo))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(dibujo);
            }

            if(boligrafoRojo.Pintar(70, out dibujo))
            {
                Console.ForegroundColor = boligrafoAzul.GetColor();
                Console.WriteLine(dibujo);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(dibujo);
            }
            Console.ReadLine();
        }
    }
}
