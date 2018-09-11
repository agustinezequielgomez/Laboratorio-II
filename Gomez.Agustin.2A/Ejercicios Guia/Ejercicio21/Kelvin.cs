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

        #region Sobrecargas
        #region Conversores
        public static explicit operator Farenheit(Kelvin k)
        {
            Farenheit far = new Farenheit((k.getCantidad() * 1.8) - 459.67);
            return far;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit) k;
            Celsius c = new Celsius((far.getCantidad() - 32) * 0.55555555555);
            return c;
        }

        public static implicit operator Kelvin(double cantidad)
        {
            Kelvin kel = new Kelvin(cantidad);
            return kel;
        }
        #endregion

        #region Comparacion
        public static bool operator ==(Kelvin k, Celsius c)
        {
            Celsius cel = new Celsius(0);
            cel = (Celsius)k;
            float aux = (float)cel.getCantidad();
            return aux == (float)c.getCantidad();
        }

        public static bool operator ==(Kelvin k, Farenheit f)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)k;
            float aux = (float)far.getCantidad();
            return aux == (float)f.getCantidad();
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.getCantidad() == k2.getCantidad();
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        public static bool operator !=(Kelvin k, Farenheit f)
        {
            return !(k == f);
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        #endregion
        #endregion
    }
}
