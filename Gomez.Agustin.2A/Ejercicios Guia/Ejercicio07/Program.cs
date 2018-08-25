using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            string fechaDeNacimiento;
            DateTime date;
            Console.Write("Ingresa tu dia de nacimiento (Formato dd/MM/yyyy) ");
            fechaDeNacimiento = Console.ReadLine();
            date = DateTime.Parse(fechaDeNacimiento);
            Console.WriteLine("Hasta ahora viviste {0:dd} días", DateTime.Now - date);
            Console.ReadLine();
        }
    }
}
