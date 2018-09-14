using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Conversor
    {
        public static string DecimalBinario(double entero)
        {
            int numero = (int)entero;
            int[] restos = new int[numero / 8];
            int divisiones = 0;
            string binario = "";
            while (numero >= 1)
            {
                restos[divisiones] = (numero % 2);
                numero = numero / 2;
                divisiones++;
            }
            Array.Reverse(restos);
            binario = string.Join("", restos);
            return binario;
        }

        public static double BinarioDecimal(string cadena)
        {
            int[] cadenaInt = new int[cadena.Length];
            double numero = 0;
            int i;
            for(i = 0; i < cadena.Length; i++)
            {
                cadenaInt[i] = (int) char.GetNumericValue(cadena[i]);
            }
            for(i = 0; i < cadena.Length; i++)
            {
                numero += (cadenaInt[i] * Math.Pow(2,cadena.Length-i-1));
            }
            return numero;
        }
    }
}