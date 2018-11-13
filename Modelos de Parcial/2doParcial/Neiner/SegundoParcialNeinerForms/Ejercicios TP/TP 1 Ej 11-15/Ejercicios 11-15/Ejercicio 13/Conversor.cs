using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double x)
        {
            string number = x.ToString();
            int fromBase = 10;
            int toBase = 2;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            return result;
        }
        public static double BinarioDecimal(string x)
        {
            string number = x;
            int fromBase = 2;
            int toBase = 10;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            return double.Parse(result);
        }
    }
}
