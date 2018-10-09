using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region Atributos
        protected int _cantidadAsientos;
        #endregion

        #region Constructores
        public Auto(string patente, byte canRuedas, EMarcas marcas, int cantidadAsientos) : base(patente,canRuedas,marcas)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public Auto(string patente, EMarcas marca, int cantidadAsientos) : this(patente,4,marca,cantidadAsientos)
        {
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("\nCantidad de asientos {0}\n", this._cantidadAsientos);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion


    }
}
