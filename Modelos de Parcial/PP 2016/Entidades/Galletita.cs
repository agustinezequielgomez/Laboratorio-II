using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Galletita : Producto
    {
        #region Atributos
        protected float _peso;
        protected static bool DeConsumo;
        #endregion

        #region Constructor
        static Galletita()
        {
            Galletita.DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso) : base(codigoBarra,marca,precio)
        {
            this._peso = peso;
        }
        #endregion

        #region Propiedades
        public override float CalcularCostoDeProduccion
        {
            get
            {
                return (this.Precio * 33) / 100;
            }
        }
        #endregion

        #region Metodo
        private static string MostrarGalletita(Galletita g)
        {
            string cadena = g;
            cadena += string.Format("\nPeso {0}\n", g._peso);
            return cadena;
        }

        public override string ToString()
        {
            return Galletita.MostrarGalletita(this);
        }

        public override string Consumir()
        {
            return base.Consumir() + "\nComestible\n";
        }
        #endregion
    }
}
