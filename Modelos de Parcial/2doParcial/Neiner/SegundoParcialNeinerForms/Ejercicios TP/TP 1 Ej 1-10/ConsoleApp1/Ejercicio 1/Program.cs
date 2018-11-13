using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int numeroIngresado;
            int maximo=0;
            int minimo=0;
            int suma=0;
            int contador;
            float promedio;
            for(contador=0;contador<5;contador++)
            {
                Console.Write("Ingrese numero: ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("Error! reingrese: ");
                }
                if(contador==0)
                {
                    maximo = numeroIngresado;
                    minimo = numeroIngresado;
                }
                else
                {
                    if(numeroIngresado>maximo)
                    {
                        maximo = numeroIngresado;
                    }
                    else
                    {
                        if(numeroIngresado<minimo)
                        {
                            minimo = numeroIngresado;
                        }
                    }
                }
                suma += numeroIngresado;
            }
            promedio = (float)suma / 5;

            Console.WriteLine("\nEl promedio es: {0:N2}", promedio);
            Console.WriteLine("El valor maximo: "+maximo);
            Console.WriteLine("El valor minimo: "+minimo);
            Console.ReadLine();
        }
    }
}