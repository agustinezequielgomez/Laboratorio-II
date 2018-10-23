using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Local(Llamada llamada, float precio) : base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.costo = precio;
        }

        public Local(string origen, float duracion, string destino, float precio) : this(new Llamada(duracion,destino,origen),precio)
        {

        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendFormat("Costo: {0}", this.CostoLlamada);
            return stringBuilder.ToString();
        }
        #endregion
    }
}
