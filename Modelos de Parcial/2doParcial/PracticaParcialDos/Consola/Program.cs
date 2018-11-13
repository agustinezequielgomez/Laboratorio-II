using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Entidades;

namespace Consola {

    class Program {

        static void ManejadorEventos(object o, CartucheraEventArgs e) {

            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\Cartuchera.txt", true);

            sw.Write(e.Util);

            sw.Close();

        }

        static void Main(string[] args) {

            Cartuchera<Utiles> cartuchera = new Cartuchera<Utiles>("La wea", 5);
            cartuchera.ElementoAgregadoEvent += ManejadorEventos;


            Lapicera l1 = new Lapicera(ConsoleColor.Black, "Fino", "Filgo", 8);
            Lapicera l2 = new Lapicera(ConsoleColor.Magenta, "Medio", "Faber Castell", 10);
            Lapicera l3 = new Lapicera(ConsoleColor.Red, "Grueso", "Maped", 7);

            Goma g1 = new Goma(true, "Filgo", 5);
            Goma g2 = new Goma(false, "Maped", 4);
            Goma g3 = new Goma(true, "Faber Castell", 6);

            cartuchera.Agregar(l1);
            cartuchera.Agregar(l2);
            cartuchera.Agregar(l3);
            cartuchera.Agregar(g1);
            cartuchera.Agregar(g2);
            cartuchera.Agregar(g3);

            Console.WriteLine(cartuchera.ObtenerUtilesBD());

            Console.Read();

        }

    }

}
