using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Farenheit
    {
        #region Atributos
        private double _cantidad;
        #endregion

        #region Constructores
        private Farenheit()
        {
            this._cantidad = 0;
        }

        public Farenheit(double cantidad) : this()
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

        #region Conversores
        public static explicit operator Celsius(Farenheit f)
        {
            Celsius c = new Celsius((f.getCantidad()-32)* 0.55555555555);
            return c;

        }


        #endregion
    }
}
