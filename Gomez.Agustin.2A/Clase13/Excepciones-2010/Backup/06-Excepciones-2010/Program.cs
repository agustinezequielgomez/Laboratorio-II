using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Excepciones_2010
{

    class PruebaExcepcion
    {
        static void Main(string[] args)
        {
            try
            {
                GenerarExcepcion(5, true);
            }

            catch (ExcepcionDemasiadosItems e)
            {
                Console.WriteLine("Mensaje: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensaje: {0}", e.Message);
            }

            finally
            {
                Console.WriteLine("Finally del Main");
                Console.ReadLine();
            }
        }


        static void GenerarExcepcion(int CantIteraciones, bool lanzoExc)
        {
            int i = 3;
            int[] MiArray = new int[i];

            try
            {
                if (lanzoExc)
                    if (CantIteraciones > MiArray.Length)
                    {
                        throw new ExcepcionDemasiadosItems();
                    }
                else
                    for (int j = 0; j < CantIteraciones; j++)
                    {
                        MiArray[j] = j + 1;
                    }
            }
            finally
            {
                Console.WriteLine("No importa lo que suceda, por el finally siempre pasa.");
                Console.WriteLine("Finally de GenerarExcepcion");
                Console.ReadLine(); 
            }

        }
    }
}
