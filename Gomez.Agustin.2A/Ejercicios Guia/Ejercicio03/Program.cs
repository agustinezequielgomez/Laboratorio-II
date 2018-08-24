using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int i;
            int j;
            int contador = 0;
            Console.WriteLine("Ingrese un numero ");
            numeros = int.Parse(Console.ReadLine());
            for(i=0;i<=numeros;i++)
            {
                contador = 0;
                for(j=1;j<=numeros;j++)
                {
                    if(i%j==0)
                    {
                        contador += 1;
                    }
                }
                if(contador==2)
                {
                    Console.WriteLine("{0} es un numero primo", i);
                }
            }
            Console.ReadLine();
        }
    }
}
