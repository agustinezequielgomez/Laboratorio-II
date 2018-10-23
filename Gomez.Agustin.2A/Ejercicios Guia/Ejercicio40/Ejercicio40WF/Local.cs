using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio40
{
    class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float precio) : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,precio)
        {
            
        }

        public Local(string origen, float duracion, string destino, float precio) : base(duracion, destino, origen)
        {
            this.costo = precio;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendFormat("Costo: {0}", this.CostoLlamada);
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
