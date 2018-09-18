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
            int i;
            for(i=0;i<20;i++)
            {
                
                Console.WriteLine("Ingrese un numero ");
                aux = int.Parse(Console.ReadLine());
                if(aux!=0)
                {
                    orden[i] = random.Next(0, 20);
                    numeros[orden[i]] = aux;
                }
            }

            Console.WriteLine("\n\nVector como fue ingresado ");
            for(i=0;i<20;i++)
            {
                Console.WriteLine("{0}", numeros[orden[i]]);
            }
            Console.Clear();
            Array.Sort(numeros);
            Console.WriteLine("\n\n\nVector ordenado ");
            foreach(int num in numeros)
            {

                 Console.WriteLine(num);
                
            }
            Console.ReadLine();
        }
    }
}
