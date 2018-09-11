using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        #region Atributos
        private double _cantidad;
        private static float _cotizRespectoDolar;
        #endregion

        #region Constructores
        private Pesos()
        {
            this._cantidad = 0;
            Pesos._cotizRespectoDolar = 17.55F;
        }

        public Pesos(double cantidad) : this()
        {
            this._cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            Pesos._cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Metodos
        public static float getCotizacion()
        {
            return Pesos._cotizRespectoDolar;
        }

        public double getCantidad()
        {
            return this._cantidad;
        }
        #endregion

        #region Sobrecargas
        #region Conversores
        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar((p._cantidad / Pesos.getCotizacion()));
            return dolar;
        }

        public static explicit operator Euro(Pesos p)
        {
            Dolar dolar = new Dolar(0);
            dolar = (Dolar) p;
            Euro euro = new Euro(dolar.getCantidad() * Euro.getCotizacion());
            return euro;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos peso = new Pesos(d);
            return peso;
        }
        #endregion

        #region Comparacion
        public static bool operator ==(Pesos p, Dolar d)
        {
            Pesos peso = new Pesos();
            peso = (Pesos) d;
            if (peso.getCantidad() == (float)p.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            Pesos peso = new Pesos();
            peso = (Pesos) e;
            if (peso.getCantidad() == (float)p.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            if (p1.getCantidad() == p2.getCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Adicion/Sustraccion
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos peso = new Pesos();
            peso = (Pesos)e;
            p._cantidad += peso.getCantidad();
            return p;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos peso = new Pesos();
            peso = (Pesos)d;
            p._cantidad += peso.getCantidad();
            return p;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos peso = new Pesos();
            peso = (Pesos)e;
            p._cantidad -= peso.getCantidad();
            return p;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos peso = new Pesos();
            peso = (Pesos)d;
            p._cantidad -= peso.getCantidad();
            return p;
        }
        #endregion
        #endregion
    }
}
