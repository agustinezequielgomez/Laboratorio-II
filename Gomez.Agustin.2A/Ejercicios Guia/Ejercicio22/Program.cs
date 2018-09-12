using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal nd1 = new NumeroDecimal(1884d);
            NumeroBinario nb1 = new NumeroBinario("10111001011");
            NumeroDecimal nd2 = new NumeroDecimal(10);
            NumeroBinario nb2 = new NumeroBinario("1110");

            Console.WriteLine(nd1._numero);
            double aux = Conversor.BinarioDecimal(nb1._numero);
            string aux2 = Conversor.DecimalBinario(1547);
            Console.WriteLine(aux);
            Console.WriteLine(aux2);


            Console.ReadLine();
        }
    }
}
