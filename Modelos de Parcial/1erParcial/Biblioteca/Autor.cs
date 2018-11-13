using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Autor
    {
        private string _nombre;
        private string _apellido;
        #region Constructor
        public Autor(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        #endregion
        #region Metodos
        public static bool operator ==(Autor autorA, Autor autorB)
        {
            bool retorno = false;
            if (autorA._nombre == autorB._nombre && autorA._apellido == autorB._apellido)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Autor autorA, Autor autorB)
        {
            return !(autorA == autorB);
        }

        public static implicit operator string(Autor autor)
        {
            return autor._nombre + "-" + autor._apellido;
        }
        #endregion
    }
}
