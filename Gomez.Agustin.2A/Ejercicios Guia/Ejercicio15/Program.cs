using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            float numeroUno;
            float numeroDos;
            char operacion;
            char continuar;
            do
            {
                Console.Write("Ingresa el primer numero ");
                numeroUno = float.Parse(Console.ReadLine());
                Console.Write("Ingresa el segundo numero ");
                numeroDos = float.Parse(Console.ReadLine());
                Console.Write("Ingresa la operacion que quieras realizar (+,-,/,*) ");
                operacion = char.Parse(Console.ReadLine());
                Calculadora.Mostrar(Calculadora.Calcular(numeroUno, numeroDos, operacion));
                Console.Write("Desea continuar con el programa (S/N) ");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (continuar == 's' || continuar == 'S');
        }
    }
}
