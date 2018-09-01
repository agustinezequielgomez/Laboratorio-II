using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
           // Program.MiMetodo("", 3);
           // Program.MiMetodo(2, "");
            //Program.MiMetodo(3);

            DateTime fecha1 = new DateTime(2005, 06, 25);
            DateTime fecha2 = new DateTime(2015, 01, 27);


            Cosa obj1 = new Cosa();
            Cosa obj2 = new Cosa("hola mundo");
            Cosa obj3 = new Cosa("hola", fecha1);
            Cosa obj4 = new Cosa("chau", fecha2, 9);

            Console.WriteLine(obj1.Mostrar());
            Console.WriteLine(obj2.Mostrar());
            Console.WriteLine(obj3.Mostrar());
            Console.WriteLine(obj4.Mostrar());



        }

        private static void MiMetodo(string a, int b)
        {
            Console.WriteLine("{0} - {1}",a,b);
           
        }

        private static void MiMetodo(int a, string b)
        {
            //Console.WriteLine("MiMetodo");
            Program.MiMetodo(b, a);
        }

        //private void MiMetodo(int a, string b)
        //{
        //    //Console.WriteLine("MiMetodo");
        //    Program.MiMetodo(b, a);
        //}

        public Program() { }

        static Program() { }
    }
}
