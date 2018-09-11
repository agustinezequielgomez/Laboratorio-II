using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Kelvin
    {
        #region Atributos
        private double _cantidad;
        #endregion

        #region Constructores
        private Kelvin()
        {
            this._cantidad = 0;
        }

        public Kelvin(double cantidad) : this()
        {
            this._cantidad = cantidad;
        }
        #endregion

        #region Metodos
        public double getCantidad()
        {
            return this._cantidad;
        }
        #endregion


    }
}
