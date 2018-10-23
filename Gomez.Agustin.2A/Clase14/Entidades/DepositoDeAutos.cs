using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {

        #region Atributos
        private int _capacidadMaxima;
        private List<Auto> _lista;
        #endregion

        #region Constructor
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }
        #endregion

        #region Metodos
        public bool Agregar(Auto a)
        {
            bool retorno = false;
            if(this._lista.Count < this._capacidadMaxima)
            {
                this._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        private int GetIndice(Auto a)
        {
            int indice = -1;
            int i = 0;
            for(i=0;i<this._lista.Count;i++)
            {
                if(this._lista[i] == a)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public bool Remover(Auto a)
        {
            bool retorno = false;
            int indice = this.GetIndice(a);
            if(indice !=-1)
            {
                this._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad máxima: {0}", this._capacidadMaxima);
            sb.AppendLine("\nListado de Autos:");
            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            return d.Agregar(a);
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            return d.Remover(a);
        }
        #endregion
    }
}
