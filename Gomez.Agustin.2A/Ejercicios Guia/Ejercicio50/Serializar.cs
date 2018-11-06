using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio50
{
    class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            string retorno = "Objeto Leido";
            return (V) Convert.ChangeType(retorno,TypeCode.String);
        }
    }
}
