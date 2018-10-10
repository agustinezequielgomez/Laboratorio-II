using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Naranju,
            Diversion,
            Swift,
            Favorita
        }

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }
        #endregion

        #region Propiedades
        public float Precio
        {
            get
            {
                return this._precio;
            }
        }

        public EMarcaProducto Marca
        {
            get
            {
                return this._marca;
            }
        }

        abstract public float CalcularCostoDeProduccion { get; }

        #endregion

        #region Constructores
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }
        #endregion

        #region Metodos
        private static string MostrarProducto(Producto p)
        {
            return string.Format("\nCodigo de barras {0}\nMarca {1}\nPrecio {2}\n", p._codigoBarra, p.Marca, p.Precio);
        }

        public override bool Equals(object obj)
        {
            return (obj is Producto&& this == (Producto)obj);
        }

        public virtual string Consumir()
        {
            return "Parte de una mezcla.";
        }
        #endregion

        #region Operadores
        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }

        public static implicit operator string(Producto p)
        {
            return Producto.MostrarProducto(p);
        }

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            return (prodUno._marca == prodDos._marca && prodUno._codigoBarra == prodDos._codigoBarra);
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            return (prodUno.Marca == marca);
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }
        #endregion
    }
}
