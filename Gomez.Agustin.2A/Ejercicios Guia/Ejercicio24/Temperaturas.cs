using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
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
            far = (Farenheit)k;
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

        #region Adicion/Sustraccion
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            Kelvin kel = new Kelvin(0);
            kel = (Kelvin)c;
            kel._cantidad += k._cantidad;
            return kel;
        }

        public static Kelvin operator +(Kelvin k, Farenheit f)
        {
            Kelvin kel = new Kelvin(0);
            kel = (Kelvin)f;
            kel._cantidad += k._cantidad;
            return kel;
        }

        public static Kelvin operator +(Kelvin k1, Kelvin k2)
        {
            return k1._cantidad + k2._cantidad;
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            Kelvin kel = new Kelvin(0);
            kel = (Kelvin)c;
            kel._cantidad -= k._cantidad;
            return kel;
        }

        public static Kelvin operator -(Kelvin k, Farenheit f)
        {
            Kelvin kel = new Kelvin(0);
            kel = (Kelvin)f;
            kel._cantidad -= k._cantidad;
            return kel;
        }

        public static Kelvin operator -(Kelvin k1, Kelvin k2)
        {
            return k1._cantidad - k2._cantidad;
        }

        #endregion
        #endregion
    }

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
            Celsius c = new Celsius((f.getCantidad() - 32) * 0.55555555555);
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
            far = (Farenheit)c;
            return (far.getCantidad() == (float)f.getCantidad());
        }

        public static bool operator ==(Farenheit f, Kelvin k)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)k;
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

        #region Adicion/Sustraccion
        public static Farenheit operator +(Farenheit f, Celsius c)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)c;
            far._cantidad += f._cantidad;
            return far;
        }

        public static Farenheit operator +(Farenheit f, Kelvin k)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)k;
            far._cantidad += f._cantidad;
            return far;
        }

        public static Farenheit operator +(Farenheit f1, Farenheit f2)
        {
            return f1._cantidad + f2._cantidad;
        }

        public static Farenheit operator -(Farenheit f, Celsius c)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)c;
            far._cantidad -= f._cantidad;
            return far;
        }

        public static Farenheit operator -(Farenheit f, Kelvin k)
        {
            Farenheit far = new Farenheit(0);
            far = (Farenheit)k;
            far._cantidad -= f._cantidad;
            return far;
        }

        public static Farenheit operator -(Farenheit f1, Farenheit f2)
        {
            return f1._cantidad - f2._cantidad;
        }
        #endregion

        #endregion
    }

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
            kel = (Kelvin)far;
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
            cel = (Celsius)f;
            if (c.getCantidad() == (float)cel.getCantidad())
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
            kel = (Kelvin)c;
            float aux = (float)kel.getCantidad();
            return aux == (float)k.getCantidad();
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.getCantidad() == c2.getCantidad();
        }

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
            cel = (Celsius)k;
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
