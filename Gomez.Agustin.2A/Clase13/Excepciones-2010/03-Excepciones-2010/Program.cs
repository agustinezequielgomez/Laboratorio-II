using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Excepciones_2010
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un número:");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el segundo número:");
                int j = int.Parse(Console.ReadLine());

                int k = i / j;
            }
            #region Bloques catch específicos
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            #region Bloque catch genérico
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
