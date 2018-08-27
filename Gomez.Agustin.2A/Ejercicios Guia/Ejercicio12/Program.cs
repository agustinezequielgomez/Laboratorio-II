using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int numeroUno;
            int numeroDos;
            int suma = 0;
            char caracter;
            Console.Write("Ingrese un numero ");
            numeroUno = int.Parse(Console.ReadLine());
            suma = numeroUno;
            do
            {
                Console.Write("Ingrese un numero para sumar ");
                numeroDos = int.Parse(Console.ReadLine());
                suma += numeroDos;
                Console.WriteLine("La suma es {0}", suma);
                Console.WriteLine("Desea continuar con el programa? (S/N) ");
                caracter = char.Parse(Console.ReadLine());
            } while (ValidarRespuesta.ValidaS_N(caracter));
        }
    }
}
