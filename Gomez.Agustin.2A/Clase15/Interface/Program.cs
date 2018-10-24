using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avion = new Avion(1000, 500);
            Carreta carreta = new Carreta(100);
            Comercial comercial = new Comercial(1000, 500, 10);
            Deportivo deportivo = new Deportivo(1000, "AAA", 500);
            Familiar familiar = new Familiar(1000, "BBB", 10);
            Privado privado = new Privado(1000, 1000, 1000);

            //AVION
            Console.WriteLine(avion.CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestNacional(avion));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(avion));

            //CARRETA
            Console.WriteLine(carreta.CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(carreta));

            //COMERCIAL
            Console.WriteLine(comercial.CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestNacional(comercial));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(comercial));

            //Comercial comercial = new Comercial(1000, 1200, 300);
            //Avion avion = new Avion(100, 5000);
            //Console.WriteLine(avion.CalcularImpuesto());
            //Console.WriteLine(Gestion.MostrarImpuestNacional(avion));
            //Console.WriteLine(((IARBA)avion).CalcularImpuesto());
            //Console.WriteLine(comercial.CalcularImpuesto());

            Console.ReadKey();
        }
    }
}
