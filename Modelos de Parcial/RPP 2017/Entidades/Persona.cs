using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        abstract protected string FichaTecnica();
        protected string NombreCompleto()
        {
            return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }
        #endregion
    }
}
