using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(int entero)
        {
            string binario = "";
            while (entero > 0)
            {
                binario = (entero % 2).ToString() + binario;
                entero = entero / 2;
            }
            return binario;
        }

        public static int BinarioDecimal(string cadena)
        {
            int numero = 0;
            int largo = cadena.Length;
            int cadenaNumero = int.Parse(cadena);
            int i;
            for(i = 1; i <= largo; i++)
            {
                numero += int.Parse(cadena[i-1].ToString()) * (int)Math.Pow(2,i);
            }
            return numero;
        }
    }
}