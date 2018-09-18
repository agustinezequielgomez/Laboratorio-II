using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
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
                dolar = (Dolar)e;
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
                euro = (Euro)d;
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
                euro = (Euro)p;
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
                euro = (Euro)d;
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
                dolar = (Dolar)p;
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
                peso = (Pesos)d;
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
                peso = (Pesos)e;
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
                dolar = (Dolar)e;
                if (dolar.getCantidad() == (float)d.getCantidad())
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
                if (d._cantidad * Pesos.getCotizacion() == (float)p.getCantidad())
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
                if (d1.getCantidad() == d2.getCantidad())
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
                dolar = (Dolar)p;
                d._cantidad += dolar.getCantidad();
                return d;
            }

            public static Dolar operator +(Dolar d, Euro e)
            {
                Dolar dolar = new Dolar();
                dolar = (Dolar)e;
                d._cantidad += dolar.getCantidad();
                return d;
            }

            public static Dolar operator -(Dolar d, Euro e)
            {
                Dolar dolar = new Dolar();
                dolar = (Dolar)e;
                d._cantidad -= dolar.getCantidad();
                return d;
            }

            public static Dolar operator -(Dolar d, Pesos p)
            {
                Dolar dolar = new Dolar();
                dolar = (Dolar)p;
                d._cantidad -= dolar.getCantidad();
                return d;

            }
            #endregion
            #endregion

        }
    
}
