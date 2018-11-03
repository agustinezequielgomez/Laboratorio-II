using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        #region Atributos
        private string mensajeBase;
        #endregion

        #region Constructor
        public DniInvalidoException() : this("Formato de DNI invalido.")
        {

        }

        public DniInvalidoException(Exception e) : base("Formato de DNI invalido.",e)
        {
            
        }

        public DniInvalidoException(string message) :  base(message)
        {
            this.mensajeBase = message;
        }

        public DniInvalidoException(string message, Exception e) : base(message,e)
        {
            this.mensajeBase = message;
        }
        #endregion
    }
}
