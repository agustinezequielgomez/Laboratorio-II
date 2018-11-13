using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        #region Atributos
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }
        #endregion

        #region Constructores
        static Jugo()
        {
            Jugo.DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor) : base(codigoBarra,marca,precio)
        {
            this._sabor = sabor;
        }
        #endregion

        #region Propiedades
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this._precio * 40) / 100;
            }
        }
        #endregion

        #region Metodos
        private string MostrarJugo()
        {
            string cadena;
            cadena = this;
            cadena += string.Format("\nSabor de jugo {0}\n", this._sabor);
            return cadena;
        }

        public override string ToString()
        {
            return this.MostrarJugo();
        }

        public override string Consumir()
        {
            return base.Consumir() + "\nBebible";
        }
        #endregion
    }
}
