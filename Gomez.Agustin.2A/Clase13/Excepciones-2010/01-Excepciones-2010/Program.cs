using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un número:");
                int i = int.Parse(Console.ReadLine());
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
