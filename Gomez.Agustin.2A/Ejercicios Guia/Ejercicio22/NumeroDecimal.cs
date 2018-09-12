using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class NumeroDecimal
    {

       
        #region Atributos
        public double _numero;
        #endregion

        #region Constructor
        public NumeroDecimal(double numero)
        {
            this._numero = numero;
        }
        #endregion
        
        #region Sobrecargas
       public static double operator +(NumeroDecimal nd, NumeroBinario nb)
       {
           double nDecimal = Conversor.BinarioDecimal(nb._numero);
           return nd._numero + nDecimal;
       }

       public static double operator -(NumeroDecimal nd, NumeroBinario nb)
       {
           double nDecimal = Conversor.BinarioDecimal(nb._numero);
           return nd._numero - nDecimal;
       }

       public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
       {
           double nDecimal = Conversor.BinarioDecimal(nb._numero);
           return nd._numero == nDecimal;
       }

       public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
       {
           return !(nd == nb);
       }

       public static implicit operator NumeroDecimal(double numero)
       {
           NumeroDecimal nd = new NumeroDecimal(numero);
           return nd;
       }

       public static explicit operator double(NumeroDecimal nd)
       {
           return nd._numero;
       }
       #endregion
       
    }
}
