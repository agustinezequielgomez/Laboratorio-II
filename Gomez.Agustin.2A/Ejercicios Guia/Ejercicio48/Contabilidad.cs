using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio48
{
    class Contabilidad<T,U>
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
    }
}
