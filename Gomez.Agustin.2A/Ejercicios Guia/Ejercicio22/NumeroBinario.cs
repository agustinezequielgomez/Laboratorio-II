using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroBinario
    {
        
        #region Atributos
        public string _numero;
        #endregion;

        #region Constructor
        public NumeroBinario(string numero)
        {
            this._numero = numero;
        }
        #endregion
        
        #region Sobrecargas
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            double numero = (double) Conversor.BinarioDecimal(nb._numero);
            double suma = numero + nd._numero;
            string retorno = Conversor.DecimalBinario((int)suma);
            return retorno;
        }

        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double numero = (double)Conversor.BinarioDecimal(nb._numero);
            double suma = numero - nd._numero;
            string retorno = Conversor.DecimalBinario((int)suma);
            return retorno;
        }

        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            string nDecimal = Conversor.DecimalBinario((int)nd._numero);
            return nb._numero == nDecimal;
        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }

        public static implicit operator NumeroBinario(string numero)
        {
            NumeroBinario nb = new NumeroBinario(numero);
            return nb;
        }

        public static explicit operator string(NumeroBinario nb)
        {
            return nb._numero;
        }
        #endregion
        
    }
}
