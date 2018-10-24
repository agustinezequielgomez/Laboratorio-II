using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial : Avion,IARBA
    {
        #region Atributos
        protected int _capacidadPasajeros;
        #endregion

        #region Propiedades
        public int CapacidadPasajeros
        {
            get
            {
                return this._capacidadPasajeros;
            }

            set
            {
                this._capacidadPasajeros = value;
            }
        }
        #endregion

        #region Constructor
        public Comercial(double precio, double velocidad, int pasajeros) : base(precio,velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }
        #endregion

        #region Metodos
        public double CalcularImpuesto()
        {
            return this.Precio * 0.25;
        }
        #endregion
    }
}
