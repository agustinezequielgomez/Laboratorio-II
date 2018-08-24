using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
  class Ejercicio_01
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 01";

      int numeros = 0;
      float total = 0;
      int minimo = 0;
      int maximo = 0;
      bool flag = true;


      int i;
      for (i = 0; i < 5; i++)
      {
        Console.Write("Ingrese un numero ");
        numeros = int.Parse(Console.ReadLine());
        total += numeros;
        if (flag == true)
        {
          flag = false;
          maximo = numeros;
          minimo = numeros;
        }

        if (numeros > maximo)
        {
          maximo = numeros;
        }
        else if (numeros < minimo)
        {
          minimo = numeros;
        }
      }
      Console.WriteLine();
      Console.WriteLine("El numero maximo es {0}", maximo);
      Console.WriteLine("El numero minimo es {0}", minimo);
      Console.WriteLine("El promedio total es {0:#.00}", total / 5);
      Console.ReadLine();
    }
  }
}
