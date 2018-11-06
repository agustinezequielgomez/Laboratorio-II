using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    class Provincial : Llamada, IGuardar<Provincial>
    {
        #region Atributos
        protected Franja franja;
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion

        #region Propiedaddes
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public bool RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion,destino,origen) 
        {
            this.franja = miFranja;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franja)
            {
                case Franja.Franja_1:
                    retorno = (float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(this.Duracion * 125);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(this.Duracion * 0.66);
                    break;
                default:
                    break;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Costo llamada: {0}\n", this.CostoLlamada);
            sb.AppendFormat("Franja Horaria: {0}", this.franja);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
