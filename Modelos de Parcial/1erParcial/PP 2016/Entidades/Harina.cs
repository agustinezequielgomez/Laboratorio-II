using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        #region Atributos
        protected ETipoHarina _tipo;
        protected static bool DeConsumo;

        public enum ETipoHarina
        {
            CuatroCeros,
            TresCeros,
            Integral
        }
        #endregion

        #region Propiedades
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.Precio * 60) / 100;
            }
        }
        #endregion

        #region Constructores
        static Harina()
        {
            Harina.DeConsumo = false;
        }

        public Harina(int codigo, float precio, EMarcaProducto marca, ETipoHarina tipo) : base(codigo,marca,precio)
        {
            this._tipo = tipo;
        }
        #endregion

        #region Metodos
        private string MostrarHarina()
        {
            string cadena = this;
            return cadena + string.Format("\nTipo de harina: {0}", this._tipo);
        }

        public override string ToString()
        {
            return this.MostrarHarina();
        }
        #endregion
    }
}
