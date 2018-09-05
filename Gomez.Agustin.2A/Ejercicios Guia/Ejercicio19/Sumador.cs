using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Constructores
        public Sumador(int cantidad)
        {
            cantidadSumas = cantidad;
        }

        public Sumador():this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public static explicit operator int(Sumador objeto)
        {
            return objeto.cantidadSumas;
        }

        public static long operator +(Sumador objeto, Sumador objeto2)
        {
            return objeto.cantidadSumas + (long)objeto2.cantidadSumas;
        }

        public static bool operator |(Sumador objeto, Sumador objeto2)
        {
            return objeto.cantidadSumas == objeto2.cantidadSumas;
        }
        #endregion
    }
}
