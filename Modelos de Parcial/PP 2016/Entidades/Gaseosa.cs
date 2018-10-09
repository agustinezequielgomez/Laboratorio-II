using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Gaseosa : Producto
    {
        #region Atributos
        protected float _litros;
        protected static bool DeConsumo;
        #endregion

        #region Constructores
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto p, float litros)
        {

        }
        #endregion
    }
}
