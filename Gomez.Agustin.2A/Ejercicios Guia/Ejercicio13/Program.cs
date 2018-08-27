using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            int opcion = 3;
            string cadena="";
            int numero;
            Console.Write("1- Convertir de binario a decimal\n2- Convertir de decimal a binario\n3- Salir\nIngrese una opcion ");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.Write("Ingrese un numero binario para convertir a decimal ");
                    cadena = Console.ReadLine();
                    numero = Conversor.BinarioDecimal(cadena);
                    Console.WriteLine("Numero convertido a decimal {0}", numero);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Ingrese un numero decimal para convertir a binario ");
                    numero = int.Parse(Console.ReadLine());
                    cadena = Conversor.DecimalBinario(numero);
                    Console.WriteLine("Numero convertido a binario {0}", cadena);
                    Console.ReadLine();
                    break;
                case 3:
                    break;
                default:
                    Console.Write("Opcion invalida. Saliendo del programa... ");
                    Console.ReadLine();
                    break;
            }

        }
    }
}
