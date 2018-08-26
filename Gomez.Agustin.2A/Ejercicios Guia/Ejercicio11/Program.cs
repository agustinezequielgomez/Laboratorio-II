using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int numeros;
            int i;
            float total = 0;
            int minimo = 0;
            int maximo = 0;
            bool flag = true;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingresa un numero ");
                numeros = int.Parse(Console.ReadLine());
                if (Validacion.Validar(numeros, -100, 100))
                {
                    if (flag == true)
                    {
                        flag = false;
                        maximo = numeros;
                        minimo = numeros;
                    }

                    if (numeros > maximo)
                    {
                        maximo = numeros;
                    }
                    else if (numeros < minimo)
                    {
                        minimo = numeros;
                    }
                    total += numeros;
                }
            }
            Console.WriteLine();
            Console.WriteLine("El numero maximo es {0}", maximo);
            Console.WriteLine("El numero minimo es {0}", minimo);
            Console.WriteLine("El promedio total es {0:#.00}", total / 10);
            Console.ReadLine();
        }
    }
}

