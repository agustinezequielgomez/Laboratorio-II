using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numeros = new int[20];
            int[] orden = new int[20];
            int aux;
            int indice = 0;
            int i;
            for(i=0;i<20;i++)
            {
                
                do
                {
                    Console.WriteLine("Ingrese un numero ");
                    aux = int.Parse(Console.ReadLine());
                } while (aux == 0);

                do
                {
                    indice = random.Next(0, 20);
                } while (numeros[indice] != 0);
                orden[i] = indice;
                numeros[orden[i]] = aux;
                
            }

            Console.WriteLine("\n\nVector como fue ingresado ");
            for(i=0;i<20;i++)
            {
                Console.WriteLine("{0}", numeros[orden[i]]);
            }
            Console.ReadLine();
            Console.Clear();
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("\n\n\nVector ordenado de forma decreciente");
            foreach(int num in numeros)
            {
                if(num > 0)
                {
                    Console.WriteLine(num);
                }
            }
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("\n\n\nVector ordenado de forma creciente");
            foreach(int num in numeros)
            {
                if(num < 0)
                {
                   Console.WriteLine(num);
                }
                
            }
            Console.ReadLine();
        }
    }
}
