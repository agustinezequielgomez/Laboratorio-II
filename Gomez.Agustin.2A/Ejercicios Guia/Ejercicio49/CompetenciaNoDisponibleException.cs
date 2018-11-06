using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
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

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, CompetenciaNoDisponibleException innerException) : base(mensaje,innerException)
        {
            this.Source = this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nExcepcion en el metodo {0} de la clase {1}:", this.NombreMetodo, this.NombreClase);
            sb.AppendLine(this.Message);
            sb.AppendFormat("\nExcepcion original: {0}\tClase: {1}",this.InnerException.Message,this.InnerException.Source);
            return sb.ToString();
        }
        #endregion
    }
}
