using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestLavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("AAA", EMarcas.Fiat, 4);
            Auto a2 = new Auto("AAAA", 4, EMarcas.Ford, 3);
            Auto a3 = new Auto("AAA", EMarcas.Fiat, 4);

            Camion c1 = new Camion("CCC",6,EMarcas.Scania,1500);
            Camion c2 = new Camion("CCCC",8, EMarcas.Scania, 100);
            Vehiculo v1 = new Vehiculo("VVV", 8, EMarcas.Iveco);
            Camion c3 = new Camion(v1, 8000);

            Moto m1 = new Moto("MMM", 2, EMarcas.Honda);
            Moto m2 = new Moto(EMarcas.Scania, 400, "MMMM1", 5);
            Moto m3 = new Moto(EMarcas.Honda, 1500, "MMM", 2);

            Lavadero l1 = new Lavadero("Manu y asociados");
            l1 += a1;
            l1 += a2;
            l1 += a3;
            l1 += c1;
            l1 += c2;
            l1 += c3;
            l1 += m1;
            l1 += m2;
            l1 += m3;

            l1.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(l1.LavaderoToString);
            Console.WriteLine(l1.MostrarTotalFacturado());
            Console.ReadLine();

        }
    }
}
