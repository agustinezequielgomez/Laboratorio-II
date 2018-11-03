using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos
        private int legajo;
        #endregion

        #region Constructor
        public Universitario() : this(0,"Sin Nombre","Sin apellido","1",ENacionalidad.Argentino)
        {
        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre,apellido,dni,nacionalidad)
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
                retorno = (((Universitario)obj) == this);
            }
            return retorno;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo);
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    }
}
