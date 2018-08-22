using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02
{
  class Program
  {
    static void Main(string[] args)
    {
      Sello.mensaje = "Agustin";
      Sello.color = ConsoleColor.Red;
      Console.WriteLine(Sello.Imprimir());
      Console.ReadLine();
      Sello.Borrar();
      Console.WriteLine(Sello.Imprimir());
      Console.ReadLine();


      Sello.mensaje = "Agustin";
      Sello.ImprimirEncolor();
      Console.ReadLine();
      Sello.color = ConsoleColor.Black;
      Sello.ImprimirEncolor();
      Console.ReadLine();


    }
  }
}
