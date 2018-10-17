using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36
{
    class Program
    {
        static void Main(string[] args)
        {
            bool algo = false;
            Competencia competencia = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(45, "Ferrari", 800);
            AutoF1 a2 = new AutoF1(88, "LKambo", 1100);
            AutoF1 a3 = new AutoF1(95, "McQueen", 95);
            AutoF1 a4 = new AutoF1(99, "Kuchau", 500);
            AutoF1 a5 = new AutoF1(878, "DD", 78);
            AutoF1 a6 = new AutoF1(45, "Ferraria", 800);
            MotoCross m1 = new MotoCross(20, "Ferrari", 500);
            algo = competencia + a1;
            algo = competencia + a2;
            algo = competencia + a3;
            algo = competencia + a4;
            algo = competencia + m1;
            algo = competencia + a6;
            Console.WriteLine(competencia.MostrarDatos());
            Console.ReadLine();
        }
    }
}
