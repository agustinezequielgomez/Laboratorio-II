using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            object[] objeto = new object[20];
            int[] array = new int[20];
            Stack pila = new Stack();
            do
            {
                Console.WriteLine("Ingrese un numero ");
                pila.Push(int.Parse(Console.ReadLine()));
            } while (pila.Count < 20);

            objeto = pila.ToArray();
            Array.Reverse(objeto);
            Console.WriteLine("Numeros como fueron ingrsados ");
            foreach (int num in objeto)
            {
                Console.WriteLine(num);
            }
        }
    }
}
