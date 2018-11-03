using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class DniInvalidoException : Exception
    {
        #region Atributos
        private string mensajeBase;
        #endregion

        #region Constructor
        public DniInvalidoException() : base()
        {

        }

        public DniInvalidoException(Exception e) : base("\nFormato de DNI invalido",e)
        {

        }

        public DniInvalidoException(string message) :  base(message)
        {
            this.mensajeBase = message;
        }
        #endregion
    }
}
