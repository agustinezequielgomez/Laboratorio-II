using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        #region Atributos
        private string nombre;
        private string raza;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }
        #endregion

        #region Constructor
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Metodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("{0} {1}", this.Nombre ,this.Raza));
            return sb.ToString();
        }
        #endregion
    }
}
