using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Excepciones_2010
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

                Console.WriteLine("Estoy en el Main y la excepción fue...");
               
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
        }

        static void Funcion1()
        {
            Console.WriteLine("Estoy en el función 1 e invoco a la función 2...");
            Console.ReadLine();

            try
            {
                Funcion2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el catch de la función 1");
                Console.WriteLine("Lanzo la excepción hacia el Main...");
                Console.ReadLine();

                throw e;
            }

        }
        static void Funcion2()
        {
            Console.WriteLine("Estoy en el función 2 e invoco a la función 3...");
            Console.ReadLine();

            try
            {
                Funcion3();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el catch de la función 2");
                Console.WriteLine("Lanzo la excepción hacia la función 1...");
                Console.ReadLine();

                throw e;
            }

        }
        static void Funcion3()
        {
            Console.WriteLine("Estoy en el función 3 e invoco a la función 4...");
            Console.ReadLine();

            try
            {
                Funcion4();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el catch de la función 3");
                Console.WriteLine("Lanzo la excepción hacia la función 2...");
                Console.ReadLine();

                throw e;
            }

        }
        static void Funcion4()
        {
            Console.WriteLine("Estoy en el función 4 e invoco a la función 5...");
            Console.ReadLine();

            try
            {
                Funcion5();
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el catch de la función 4");
                Console.WriteLine("Lanzo la excepción hacia la función 3...");
                Console.ReadLine();

                throw e;
            }

        }
        static void Funcion5()
        {
            Console.WriteLine("Estoy en el función 5 y genero una excepción...");

            Console.WriteLine("Escriba un número");
            
            try
            {
                int i = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el catch de la función 5");
                Console.WriteLine("Lanzo la excepción hacia la función 4...");
                Console.ReadLine();

                throw e;
            }

        }
        
    }
}
