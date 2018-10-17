using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            bool algo = false;
            Competencia competencia = new Competencia(10, 5);
            AutoF1 a1 = new AutoF1(45, "Ferrari");
            AutoF1 a2 = new AutoF1(23, "Bugatti");
            AutoF1 a3 = new AutoF1(98, "Maseratti");
            AutoF1 a4 = new AutoF1(12, "Mercedes-Benz");
            AutoF1 a5 = new AutoF1(20, "Fiat");

            algo = competencia + a1;
            algo = competencia + a2;
            algo = competencia + a3;
            algo = competencia + a4;
            algo = competencia + a5;
            Console.WriteLine(competencia.MostrarDatos());
            Console.ReadLine();
        }
    }
}
