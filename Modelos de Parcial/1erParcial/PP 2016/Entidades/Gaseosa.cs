using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        #region Atributos
        protected float _litros;
        protected static bool DeConsumo;
        #endregion

        #region Propiedades
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.Precio * 42) / 100;
            }
        }
        #endregion

        #region Constructores
        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros) : base(codigoBarra,marca,precio)
        {
            this._litros = litros;
        }

        /*public Gaseosa(Producto p, float litros)
        {
            
        }*/
        #endregion

        #region Metodos
        private string MostrarGaseosa()
        {
            string cadena = this;
            return cadena + string.Format("\nLitros {0}", this._litros);
        }

        public override string ToString()
        {
            return this.MostrarGaseosa();
        }
        
        public override string Consumir()
        {
            return base.Consumir() + "\nBebible\n";
        }
        #endregion
    }
}
