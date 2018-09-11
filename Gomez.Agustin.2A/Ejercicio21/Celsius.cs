using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Celsius
    {
        #region Atributos
        private double _cantidad;
        #endregion

        #region Constructores
        private Celsius()
        {
            this._cantidad = 0;
        }

        public Celsius(double cantidad) : this()
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
        #region Conversor
        public static explicit operator Farenheit(Celsius c)
        {
            Farenheit far = new Farenheit((c.getCantidad() * 1.8) + 32);
            return far;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)c;
            Kelvin kel = new Kelvin((far.getCantidad() + 459.67) * 1.8);
            return kel;
        }

        public static implicit operator Celsius(double cantidad)
        {
            Celsius cel = new Celsius(cantidad);
            return cel;
        }
        #endregion

        #region Comparacion
        public static bool operator ==(Celsius c, Farenheit f)
        {
            Celsius cel = new Celsius(0);
            cel = (Celsius) f;
            if(c.getCantidad() == cel.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public static bool operator !=(Celsius c, Farenheit f)
        {
            return !(c == f);
        }


        #endregion
        #endregion
    }
}
