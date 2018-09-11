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
            Kelvin kel = new Kelvin(0);
            kel = (Kelvin) far;
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
            if(c.getCantidad() == (float) cel.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            Kelvin kel = new Kelvin(0);
            kel = (Kelvin) c;
            float aux = (float) kel.getCantidad();
            return  aux  == (float)k.getCantidad();
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.getCantidad() == c2.getCantidad();        }

        public static bool operator !=(Celsius c, Farenheit f)
        {
            return !(c == f);
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }


        #endregion

        #region Adicion/Sustraccion
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            Celsius cel = new Celsius(0);
            cel = (Celsius) k;
            cel._cantidad += c.getCantidad();
            return cel;
        }

        public static Celsius operator +(Celsius c, Farenheit f)
        {
            Celsius cel = new Celsius(0);
            cel = (Celsius)f;
            cel._cantidad += c.getCantidad();
            return cel;
        }

        public static Celsius operator +(Celsius c1, Celsius c2)
        {
            return c1._cantidad + c2._cantidad;
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            Celsius cel = new Celsius(0);
            cel = (Celsius)k;
            cel._cantidad -= c.getCantidad();
            return cel;
        }

        public static Celsius operator -(Celsius c, Farenheit f)
        {
            Celsius cel = new Celsius(0);
            cel = (Celsius)f;
            cel._cantidad -= c.getCantidad();
            return c;
        }

        public static Celsius operator -(Celsius c1, Celsius c2)
        {
            return c1._cantidad - c2._cantidad;
        }
        #endregion

        #endregion
    }
}
