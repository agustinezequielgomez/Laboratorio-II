using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Ejercicio_01
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 01";

      int numeros = 0;
      double potencia;


      do
      {
        Console.Write("Ingresar un numero ");
        numeros = int.Parse(Console.ReadLine());
        if (numeros != 0)
        {
          potencia = Math.Pow(numeros, 2);
          Console.WriteLine("La potencia al cuadrado del numero {0} es {1}", numeros, potencia);
          Console.WriteLine();
          potencia = Math.Pow(numeros, 3);
          Console.WriteLine("La potencia al cubo del numero {0} es {1}", numeros, potencia);
          Console.ReadLine();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("ERROR ¡Reingresar numero!");
          Console.ForegroundColor = ConsoleColor.Gray;
        }

        } while (numeros == 0) ;
      }
    }
  }


