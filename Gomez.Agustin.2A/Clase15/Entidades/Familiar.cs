using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Auto
    {
        #region Atribtçutos
        protected int _cantAsientos;
        #endregion

        #region Propiedades
        public int CantidadAsientos
        {
            get
            {
                return this._cantAsientos;
            }

            set
            {
                this._cantAsientos = value;
            }
        }
        #endregion

        #region Constructor
        public Familiar(double precio, string patente, int cantidadAsientos) : base(precio, patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
        #endregion
    }
}
