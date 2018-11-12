using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio62
{
    class Program
    {
        static void Main(string[] args)
        {
            //EntidadesDAO.CrearTabla();
            Local local = new Local("1115", 15, "2225", 1);
            Provincial provincial = new Provincial("111", Provincial.Franja.Franja_1, 1, "222");
            //LocalDAO.Guardar(local);
            ProvincialDAO.Guardar(provincial);
            Console.WriteLine("\n" + LocalDAO.Leer(15, 0, "1115", "2225"));
            Console.WriteLine(ProvincialDAO.Leer(1,1,"111","222").ToString());

            Console.ReadKey();
           
        }
    }
}
