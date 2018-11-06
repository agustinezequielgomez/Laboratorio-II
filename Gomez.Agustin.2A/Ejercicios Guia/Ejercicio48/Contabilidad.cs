using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    class Contabilidad<T,U> where T : Documento where U : Documento,new()
    {
        #region Atributos
        private List<T> egresos;
        private List<U> ingresos;
        #endregion

        #region Constructor
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in this.egresos)
            {
                sb.AppendLine(item.ToString());
            }

            foreach (U item in this.ingresos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }
        #endregion
    }
}
