using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region Atributos
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;
        #endregion

        #region Propiedades
        public string Patente
        {
            get
            {
                return this._patente;
            }
        }

        public byte CantRuedas
        {
            get
            {
                return this._cantRuedas;
            }
            set
            {
                this._cantRuedas = value;
            }
        }

        public EMarcas Marcas
        {
            get
            {
                return this._marca;
            }
        }
        #endregion

        #region Constructor
        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this._patente = patente;
            this.CantRuedas = cantRuedas;
            this._marca = marca;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}\nRuedas: {1}\nPatente: {2}", this.Marcas, this.CantRuedas, this.Patente);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Marcas == v2.Marcas && v1.Patente == v2.Patente);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
