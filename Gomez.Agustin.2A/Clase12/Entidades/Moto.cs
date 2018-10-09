using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributos
        protected float _cilindrada;
        #endregion

        #region Constructores
        public Moto(string patente, byte cantRuedas, EMarcas marca) : this(marca, 100,patente, cantRuedas )
        {
        }

        public Moto(EMarcas marca,float cilindrada ,string patente, byte cantRuedas) : base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("\nCilindrada {0}\n", this._cilindrada);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
