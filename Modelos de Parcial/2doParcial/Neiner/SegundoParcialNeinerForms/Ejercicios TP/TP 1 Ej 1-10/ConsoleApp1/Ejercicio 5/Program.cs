using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int ingreso;
            int contador;
            int contadorDos;
            int primerSuma=0;
            int segundaSuma=0;
            Console.Write("Ingrese Numero: ");
            while (!int.TryParse(Console.ReadLine(), out ingreso) || ingreso < 1)
            {
                Console.Write("Error, reingrese: ");
            }
            for (contador=1;contador<=ingreso;contador++)
            {
                for(contadorDos=1;contadorDos<contador;contadorDos++)
                {
                    primerSuma += contadorDos;
                }
                for (contadorDos = contador+1; contadorDos <= ingreso; contadorDos++)
                {
                    segundaSuma += contadorDos;
                    if (primerSuma == segundaSuma)
                    {
                        Console.WriteLine("Entre 1 y "+contadorDos+": "+contador);
                    }
                }
                segundaSuma = 0;
                primerSuma = 0;
            }
            Console.Read();
        }
    }
}
