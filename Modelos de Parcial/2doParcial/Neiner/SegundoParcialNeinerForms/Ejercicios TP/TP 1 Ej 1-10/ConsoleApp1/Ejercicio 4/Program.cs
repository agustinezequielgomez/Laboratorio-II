using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            int contador;
            int numero;
            int encontrados=0;
            int suma = 0;
            while(encontrados!=4)
            {
                for(numero=1;encontrados!=4;numero++)
                {
                    for(contador=1;contador<=numero/2;contador++)
                    {
                        if(numero%contador==0)
                        {
                            suma += contador;
                        }
                        if(suma==numero && contador==numero/2)
                        {
                            Console.WriteLine(numero);
                            encontrados++;
                        }
                    }
                    suma = 0;
                }
            }
            Console.Read();
        }
    }
}
