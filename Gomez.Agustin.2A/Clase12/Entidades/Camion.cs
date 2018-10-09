using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        #region Atributos
        protected float _tara;
        #endregion

        #region Constructores
        public Camion(string patente, byte cantRuedas, EMarcas marca, float tara) : base(patente,cantRuedas,marca)
        {
            this._tara = tara;
        }

        public Camion(Vehiculo vehiculo, float tara) : this(vehiculo.Patente,vehiculo.CantRuedas,vehiculo.Marcas,tara)
        {
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendFormat("\nTara: {0}\n", this._tara);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
