using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43
{
    class CompetenciaNoDisponibleException : Exception
    {
        #region Atributos
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region Propiedades
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion

        #region Constructores
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje,clase,metodo,null)
        {

        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion

        #region Constructores
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nExcepcion en el metodo {0} de la clase {1}:\n", this.NombreMetodo, this.NombreClase);
            sb.AppendLine(this.Message);
            sb.AppendFormat("{0}\t",this.Message);
            return sb.ToString();
        }
        #endregion
    }
}
