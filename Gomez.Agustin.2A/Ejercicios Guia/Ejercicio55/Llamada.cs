using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio55
{
    abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        abstract public float CostoLlamada { get;}

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrgien)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrgien;
        }
        #endregion

        #region Metodos
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = -1;
            if(llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if(llamada1.Duracion == llamada2.Duracion)
            {
                retorno = 0;
            }
            return retorno;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDuracion de la llamada: {0}", this.Duracion);
            sb.AppendFormat("\nNumero de destino: {0}", this.NroDestino);
            sb.AppendFormat("\nNumero de origen: {0}", this.NroOrigen);
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
