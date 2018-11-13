using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            int numero;
            int minimo=0;
            int maximo=0;
            float promedio=0;
            for (contador = 0; contador < 10; contador++)
            {
                Console.Write("Ingrese numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero) || !Validacion.validar(-100, numero, 100))
                {
                    Console.Write("Error!, reingrese: ");
                }
                if(contador==0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else
                {
                    if(numero>maximo)
                    {
                        maximo = numero;
                    }
                    else
                    {
                        if(numero<minimo)
                        {
                            minimo = numero;
                        }
                    }
                }
                promedio += numero;
            }
            promedio = promedio / contador;
            Console.WriteLine("Promedio: {0:N2}", promedio);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Maximo: {0}", maximo);
            Console.Read();
        }
    }
}
