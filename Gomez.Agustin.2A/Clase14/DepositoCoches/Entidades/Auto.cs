using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {

        #region Atributos
        private string _color;
        private string _marca;
        #endregion

        #region Propiedades
        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }
        #endregion

        #region Constructores
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            return (obj is Auto && this == (Auto)obj);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}", this.Marca);
            sb.AppendFormat(" - Color: {0}", this.Color);
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Auto a, Auto b)
        {
            return (a.Color == b.Color && a.Marca == b.Marca);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        #endregion

    }
}
