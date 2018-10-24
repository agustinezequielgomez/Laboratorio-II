using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado : Avion
    {
        #region Atributos
        protected int _valoracionServicioDeAbordo;
        #endregion

        #region Propiedades
        public int ServicioDeAbordo
        {
            get
            {
                return this._valoracionServicioDeAbordo;
            }

            set
            {
                this._valoracionServicioDeAbordo = value;
            }
        }
        #endregion

        #region Constructor
        public Privado(double precio, double velocidad, int valoracion) : base(precio, velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }
        #endregion
    }
}
