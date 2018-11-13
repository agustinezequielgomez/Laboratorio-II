using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int contador;
            double numeroDecimal;
            string numeroBinario;
            Console.WriteLine("1- Decimal a Binario");
            Console.WriteLine("2- Binario a Decimal");
            Console.Write("Su opcion: ");
            while (!int.TryParse(Console.ReadLine(),out opcion))
            {
                Console.Write("Error, reingrese: ");
            }
            if(opcion==1)
            {
                Console.WriteLine("Ingrese numero decimal: ");
                while (!double.TryParse(Console.ReadLine(), out numeroDecimal))
                {
                    Console.WriteLine("Error, reingrese: ");
                }
                numeroBinario=Conversor.DecimalBinario(numeroDecimal);
                Console.WriteLine("Su numero es: " + numeroBinario);
            }
            else
            {
                if (opcion == 2)
                {
                    Console.WriteLine("Ingrese numero binario: ");
                    numeroBinario = Console.ReadLine();
                    for(contador=0;contador<numeroBinario.Length;contador++)
                    {
                        if(numeroBinario[contador]!='0' && numeroBinario[contador]!='1')
                        {
                            Console.WriteLine("Error, no ingresaste un numero binario, vuelve a ejecutar el programa");
                            Console.Read();
                            Environment.Exit(0);
                        }
                    }
                    numeroDecimal=Conversor.BinarioDecimal(numeroBinario);
                    Console.WriteLine("Su numero es: " + numeroDecimal);
                }
            }
            Console.Read();
        }
    }
}
