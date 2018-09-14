using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase08
{
    public class Paleta
    {
        #region Atributos
        private Tempera[] _colores;
        private int _cantMaximaelementos;
        #endregion

        #region Constructor
        private Paleta() : this(5)
        {

        }

        private Paleta(int cantElementos)
        {
            this._cantMaximaelementos = cantElementos;
            this._colores = new Tempera[this._cantMaximaelementos];
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string retorno = "Cantidad maxima de elementos: " + this._cantMaximaelementos + "\n\nColores utilizados en la paleta:\n ";
            string cadenaAux = "";
            foreach (Tempera temperas in this._colores)
            {
                cadenaAux += temperas;
            }
            retorno += cadenaAux;
            return retorno;
        }

        private int ObtenerIndice()
        {
            int i;
            int indice = -1;
            for (i = 0; i < this._cantMaximaelementos; i++)
            {
                if (!Object.Equals(this._colores[i],null))
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        private int ObtenerIndice(Tempera t)
        {
            int indice = -1;
            int i;
            for(i = 0; i < this._cantMaximaelementos; i++)
            {
                if(!(Object.Equals(this._colores[indice],null)) && this._colores[i] == t)
                {
                    indice = i;
                }
            }
            return indice;
        }
        #endregion

        #region Sobrecarga
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad); ;
        }

        public static bool operator ==(Paleta p, Tempera t)
        {

              foreach (Tempera item in p._colores)
                {
                  if (!(Object.Equals(item, null)) && t == item)
                  {
                      return true;
                  }        
              }
            return false;
            /*for (int i = 0; i < p._cantMaximaelementos; i++)
            {
                if (p._colores.GetValue(i)!=null)
                 {
                     if (p._colores[i]==t)
                      {
                           return true;
                      }
                }
                */
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            int indice = p.ObtenerIndice(t);
            if(indice != -1)
            {
                p._colores[indice] += t;
            }
            else
            {
                indice = p.ObtenerIndice();
                if (indice != -1)
                {
                    p._colores[indice] = t;
                }
            }
            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            int indice;
            sbyte aux1;
            sbyte aux2;
            indice = p.ObtenerIndice(t);
            if(indice != -1)
            {
                aux1 = (sbyte)t;
                p._colores[indice] += (sbyte)(aux1*(-1));
                aux2 = (sbyte)p._colores[indice];
                if(aux2<=0)
                {
                    p._colores[indice] = null;
                }
            }
            return p;
        }
        #endregion
    }
}
