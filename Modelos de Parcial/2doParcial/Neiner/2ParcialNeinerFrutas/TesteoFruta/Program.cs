using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteoFruta
{
    class Program
    {
        static void Main(string[] args)
        {
            Entidades.Program programa = new Entidades.Program();
            string[] test = { "", "" };
            //programa.Main(test); // HACE FALTA CAMBIAR A PUBLIC EL METODO MAIN DE PROGRAM
            Console.ReadKey();
        }
    }
}
