using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Excepciones_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estoy en el Main e invoco a la función 1...");
            Console.ReadLine();
            try
            {
                Funcion1();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
            
        }

        static void Funcion1()
        {
            Console.WriteLine("Estoy en el función 1 e invoco a la función 2...");
            Console.ReadLine();

            Funcion2();
        }
        static void Funcion2()
        {
            Console.WriteLine("Estoy en el función 2 e invoco a la función 3...");
            Console.ReadLine();

            Funcion3();
        }
        static void Funcion3()
        {
            Console.WriteLine("Estoy en el función 3 e invoco a la función 4...");
            Console.ReadLine();

            //try
            //{
                Funcion4();

            //}
            //catch (Exception e)
            //{
                
            //    Console.WriteLine(e.StackTrace);
            //    Console.ReadLine();
            
            //}
        }
        static void Funcion4()
        {
            Console.WriteLine("Estoy en el función 4 e invoco a la función 5...");
            Console.ReadLine();

            Funcion5();
        }
        static void Funcion5()
        {
            Console.WriteLine("Estoy en el función 5 y genero una excepción...");

            Console.WriteLine("Escriba un número");
            
            int i = int.Parse(Console.ReadLine());
        }
    }
}
