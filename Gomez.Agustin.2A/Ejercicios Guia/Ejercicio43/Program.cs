using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class Program
    {
        static void Main(string[] args)
        {
            bool algo = false;
            Competencia c = new Competencia(9, 5, Competencia.TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(20, "Ferrari");
            MotoCross m1 = new MotoCross(30, "Lambo");
            try
            {
                algo = c + a1;
                algo = c + m1;
            }
            catch(CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }


            Console.ReadKey();
        }
    }
}
