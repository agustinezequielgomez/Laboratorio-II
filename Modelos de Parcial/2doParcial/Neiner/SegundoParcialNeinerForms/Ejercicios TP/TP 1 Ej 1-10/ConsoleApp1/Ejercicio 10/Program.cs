using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";
            int tamano;
            int contador;
            int contadorDos;
            string asterisco = "*";
            Console.Write("Ingrese tamano: ");
            while(!int.TryParse(Console.ReadLine(),out tamano) || tamano<1)
            {
                Console.Write("Error, reingrese: ");
            }

            for (contador = 0; contador < tamano; contador++)
            {
                if(contador<tamano)
                {
                    for(contadorDos=tamano-contador;contadorDos>0;contadorDos--)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(asterisco);
                asterisco += "**";
            }
            Console.Read();
        }
    }
}
