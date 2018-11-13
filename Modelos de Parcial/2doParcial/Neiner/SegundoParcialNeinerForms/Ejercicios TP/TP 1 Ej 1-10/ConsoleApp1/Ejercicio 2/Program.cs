using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            int ingresoNumero;
            int contador;
            Console.Write("Ingrese numero: ");

            while(!int.TryParse(Console.ReadLine(), out ingresoNumero) || ingresoNumero <=0)
            {
                Console.WriteLine("Error. Reingresar numero!!!");
            }
            for(contador=2;contador<=3;contador++)
            {
                Console.WriteLine(ingresoNumero+" elevado a la "+contador+" es "+Math.Pow(ingresoNumero, contador));
            }
            Console.Read();
        }
    }
}
