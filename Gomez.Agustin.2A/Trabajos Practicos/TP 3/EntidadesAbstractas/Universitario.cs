using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructor
        public Universitario() : this(12,"Pedro","Gonzalez","340",ENacionalidad.Argentino)
        {
        }

        public Universitario(int legajo, string nombre, string apellido,string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("\nLEGAJO NUMERO: {0}", this.legajo);
            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Universitario)
            {
                retorno = (obj == this);
            }
            return retorno;
        }
        #endregion
    }
}
