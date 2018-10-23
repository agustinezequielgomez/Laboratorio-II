using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    abstract class Sobreescrito
    {
        #region Atributos
        protected string miAtributo;
        #endregion

        #region Propiedades
        public abstract string MiPropiedad { get; }
        #endregion

        #region Construtor
        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        #endregion

        #region Metodos
        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return (obj is Sobreescrito);
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
        #endregion
    }
}
