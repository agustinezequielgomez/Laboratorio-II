using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    class Conversion
    {
        public static string BinarioDecimal(string binario)
        {
            int[] cadenaInt = new int[binario.Length];
            string retorno = "";
            double numero = 0;
            bool flag = true;
            int i;
            for (i = 0; i < binario.Length; i++)
            {
                cadenaInt[i] = (int)char.GetNumericValue(binario[i]);
                if (cadenaInt[i] != 0 && cadenaInt[i] != 1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                for (i = 0; i < binario.Length; i++)
                {
                    numero += (cadenaInt[i] * Math.Pow(2, binario.Length - i - 1));
                }
                retorno = numero.ToString();
            }
            else
            {
                retorno = "Valor invalido";
            }

            return retorno;
        }

        public static string DecimalBinario(double entero)
        {
            int numero = (int)entero;
            string binario = "";
            while (numero > 0)
            {
                binario += (numero % 2).ToString();
                numero = numero / 2;
            }
            char[] charArray = binario.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
