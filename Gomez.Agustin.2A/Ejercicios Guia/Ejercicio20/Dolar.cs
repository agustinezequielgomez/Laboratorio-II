using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        #region Atributos
        private double _cantidad;
        private static float _cotizRespectoDolar;
        #endregion

        #region Constructores
        private Dolar()
        {
            this._cantidad = 0;
            Dolar._cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
        {
            Dolar._cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Metodos
        public static float getCotizacion()
        {
            return Dolar._cotizRespectoDolar;
        }

        public double getCantidad()
        {
            return this._cantidad;
        }
        #endregion

        #region Sobrecargas
        #region Conversores
        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro((d._cantidad / Euro.getCotizacion()));
            return euro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos peso = new Pesos((d._cantidad) * Pesos.getCotizacion());
            return peso;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);
            return dolar;
        }
        #endregion

        #region Comparacion
        public static bool operator ==(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.getCantidad());
            dolar = (Dolar) e;
            if(dolar.getCantidad() == (float) d.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            if (d._cantidad * Pesos.getCotizacion() == p.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if(d1.getCantidad() == d2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        #endregion

        #region Adicion/Sustraccion
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar dolar = new Dolar();
            dolar = (Dolar) p;
            d._cantidad += dolar.getCantidad();
            return d;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar();
            dolar = (Dolar) e;
            d._cantidad += dolar.getCantidad();
            return d;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar();
            dolar = (Dolar) e;
            d._cantidad -= dolar.getCantidad();
            return d;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar dolar = new Dolar();
            dolar = (Dolar) p;
            d._cantidad -= dolar.getCantidad();
            return d;

        }
        #endregion
        #endregion

    }
}
