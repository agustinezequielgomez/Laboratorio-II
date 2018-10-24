using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47Lib
{
    public abstract class Equipo
    {
        #region Atributos
        protected string nombre;
        protected DateTime fechaDeCreacion;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

        }
        #endregion

        #region Constructor
        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaDeCreacion = fecha;
        }
        #endregion

        #region Metodos
        public string Ficha()
        {
            return string.Format("\n{0} fundado el {1}", this.nombre, this.fechaDeCreacion);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return (equipo1.nombre == equipo2.nombre && equipo1.fechaDeCreacion.ToShortDateString() == equipo2.fechaDeCreacion.ToShortDateString());
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
        #endregion
    }
}
