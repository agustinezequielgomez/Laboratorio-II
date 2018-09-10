using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        #region Atributos
        private double _cantidad;
        private static float _cotizRespectoDolar;
        #endregion

        #region Constructores
        private Euro()
        {
            this._cantidad = 0;
            Euro._cotizRespectoDolar = 1.3642F;
        }

        public Euro(double cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            Euro._cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Metodos
        public static float getCotizacion()
        {
            return Euro._cotizRespectoDolar;
        }

        public double getCantidad()
        {
            return this._cantidad;
        }
        #endregion

        #region Sobrecargas
        #region Conversores
        public static explicit operator Dolar(Euro e)
        {
            Dolar dolar = new Dolar((e._cantidad * Euro.getCotizacion()));
            return dolar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Dolar dolar = new Dolar(0);
            dolar = (Dolar) e;
            Pesos peso = new Pesos(dolar.getCantidad() * Pesos.getCotizacion());
            return peso;
        }

        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);
            return euro;
        }
        #endregion

        #region Comparacion
        public static bool operator ==(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.getCantidad());
            euro = (Euro) d;
            if (euro.getCantidad() == (float)e.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            Euro euro = new Euro(0);
            euro = (Euro)p;
            if (euro.getCantidad() == (float)e.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.getCantidad() == e2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        #endregion

        #region Adicion/Sustraccion
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro euro = new Euro();
            euro = (Euro) p;
            e._cantidad += euro.getCantidad();
            return e;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro euro = new Euro();
            euro = (Euro)d;
            e._cantidad += euro.getCantidad();
            return e;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro euro = new Euro();
            euro = (Euro) d;
            e._cantidad -= euro.getCantidad();
            return e;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro euro = new Euro();
            euro = (Euro)p;
            e._cantidad -= euro.getCantidad();
            return e;
        }
        #endregion
        #endregion
    }
}
