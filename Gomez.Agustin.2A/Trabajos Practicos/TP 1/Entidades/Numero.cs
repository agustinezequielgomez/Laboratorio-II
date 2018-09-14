using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        #region Atributos
        private double _numero;
        #endregion

        #region Propiedades
        private string SetNumero
        {
            set
            {
                double numero;
                numero = ValidarNumero(value);
                _numero = numero;
            }
        }

        #endregion

        #region Constructor
        public Numero() : this(0)
        {

        }

        public Numero(double numero)
        {
            this._numero = numero;
        }

        public Numero(string strNumero) 
        {
            SetNumero = strNumero;
        }
        #endregion

        #region Metodos
        public string DecimalBinario(double entero)
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

        public double BinarioDecimal(string binario)
        {
            int[] cadenaInt = new int[binario.Length];
            double numero = 0;
            int i;
            for (i = 0; i < binario.Length; i++)
            {
                cadenaInt[i] = (int)char.GetNumericValue(binario[i]);
            }
            for (i = 0; i < binario.Length; i++)
            {
                numero += (cadenaInt[i] * Math.Pow(2, binario.Length - i - 1));
            }
            return numero;
        }

        private double ValidarNumero(string strNumero)
        {
            double numero;
            double.TryParse(strNumero, out numero);
            return numero;
        }
        #endregion

        #region Sobrecargas
        public static double operator +(Numero n1, Numero n2)
        {
            return n1._numero + n2._numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1._numero - n2._numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1._numero * n2._numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1._numero / n2._numero;
        }
        #endregion

    }
}
