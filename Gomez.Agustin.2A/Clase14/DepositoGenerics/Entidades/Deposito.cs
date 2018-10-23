using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {

        #region Atributos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion

        #region Constructor
        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        #endregion

        #region Metodos
        private int GetIndice(T a)
        {
            int indice = -1;
            int i;
            for(i = 0; i < this._lista.Count; i++)
            {
                if(this._lista[i].Equals(a))
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad máxima: {0}", this._capacidadMaxima);
            sb.AppendFormat("\nListado de {0}:", typeof(T).Name);
            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if(d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if(indice != -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
