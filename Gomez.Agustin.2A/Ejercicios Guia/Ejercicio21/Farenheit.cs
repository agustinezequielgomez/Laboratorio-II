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

        #region Sobrecargas
        #region Conversores
        public static explicit operator Celsius(Farenheit f)
        {
            Celsius c = new Celsius((f.getCantidad()-32)* 0.55555555555);
            return c;
        }

        public static explicit operator Kelvin(Farenheit f)
        {
            Kelvin k = new Kelvin((f.getCantidad() + 459.67) * 0.55555555555);
            return k;
        }

        public static implicit operator Farenheit(double cantidad)
        {
            Farenheit far = new Farenheit(cantidad);
            return far;
        }
        #endregion

        #region Comparacion

        public static bool operator ==(Farenheit f, Celsius c)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit) c;
            return (far.getCantidad() == (float)f.getCantidad());
        }

        public static bool operator ==(Farenheit f, Kelvin k)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit) k;
            return (far.getCantidad() == (float)f.getCantidad());
        }

        public static bool operator ==(Farenheit f1, Farenheit f2)
        {
            return f1.getCantidad() == f2.getCantidad();
        }

        public static bool operator !=(Farenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator !=(Farenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static bool operator !=(Farenheit f1, Farenheit f2)
        {
            return !(f1 == f2);
        }
        #endregion

        #endregion
    }
}
