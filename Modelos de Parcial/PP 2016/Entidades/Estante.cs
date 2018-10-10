using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region Atributos
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        #endregion

        #region Propiedades
        public float ValorEstanteTotal
        {
            get
            {
                return this.GetValorEstante();
            }
                
        }
        #endregion

        #region Constructores
        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        #endregion

        #region Metodos
        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Estante\nCantidad de espacios {0}", e._capacidad);
            foreach (Producto item in e._productos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        private float GetValorEstante()
        {
            return GetValorEstante(ETipoProducto.Todos);
        }

        public float GetValorEstante(ETipoProducto tipoProducto)
        {
            float retorno = 0;
            foreach (Producto item in this._productos)
            {
                switch (tipoProducto)
                {
                    case ETipoProducto.Galletita:
                        if(item is Galletita)
                        {
                            retorno = item.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Gaseosa:
                        if (item is Gaseosa)
                        {
                            retorno = item.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Jugo:
                        if (item is Jugo)
                        {
                            retorno = item.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Harina:
                        if (item is Harina)
                        {
                            retorno = item.CalcularCostoDeProduccion;
                        }
                        break;
                    case ETipoProducto.Todos:
                        retorno = item.CalcularCostoDeProduccion;
                        break;
                    default:
                        break;
                }
            }
            return retorno;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Estante e, Producto prod)
        {
            bool retorno = false;
            foreach (Producto item in e._productos)
            {
                if(item == prod)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        public static bool operator +(Estante e, Producto prod)
        {
            return ((e != prod) && (e._productos.Count - e._capacidad >= 1));
        }

        public static Estante operator -(Estante e, Producto prod)
        {
            if(e == prod)
            {
                e._productos.Remove(prod);
            }
            return e;
        }

        public static Estante operator -(Estante e, ETipoProducto tipoProducto)
        {
            foreach (Producto item in e._productos)
            {
                switch (tipoProducto)
                {
                    case ETipoProducto.Galletita:
                        if(!(item is Galletita))
                        {
                            e._productos.Remove(item);
                        }
                        break;
                    case ETipoProducto.Gaseosa:
                        if (!(item is Gaseosa))
                        {
                            e._productos.Remove(item);
                        }
                        break;
                    case ETipoProducto.Jugo:
                        if (!(item is Jugo))
                        {
                            e._productos.Remove(item);
                        }
                        break;
                    case ETipoProducto.Harina:
                        if (!(item is Harina))
                        {
                            e._productos.Remove(item);
                        }
                        break;
                    case ETipoProducto.Todos:
                        e._productos.Remove(item);
                        break;
                    default:
                        break;
                }
            }
            return e;
        }
        #endregion
    }
}
