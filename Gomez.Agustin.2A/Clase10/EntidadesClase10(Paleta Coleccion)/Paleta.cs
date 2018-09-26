using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase10
{
    public class PaletaColeccion
    {
        #region Atributos
        private List<Tempera> _colores;
        private int _cantMaximaelementos;
        #endregion

        #region Constructor
        private PaletaColeccion() : this(5)
        {

        }

        private PaletaColeccion(int cantElementos)
        {
            this._cantMaximaelementos = cantElementos;
            this._colores = new List<Tempera>(this._cantMaximaelementos);
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string retorno = "Cantidad maxima de elementos: " + this._cantMaximaelementos + "\r\nColores utilizados en la paleta: ";
            string cadenaAux = "";
            string cadenaAux2 = "";
            foreach (Tempera temperas in this._colores)
            {
                if(!(Object.Equals(temperas,null)))
                {
                    cadenaAux2 = temperas;
                    cadenaAux += cadenaAux2;
                }
            }
            retorno += cadenaAux;
            return retorno;
        }

        /*private int ObtenerIndice()
        {
            int i;
            int indice = -1;
            for (i = 0; i < this._cantMaximaelementos; i++)
            {
                if (Object.Equals(this._colores[i],null))
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
                if(!(Object.Equals(this._colores[i],null)) && this._colores[i] == t)
                {
                    indice = i;
                }
            }
            return indice;
        }*/
        #endregion

        #region Sobrecarga
        public static explicit operator string(PaletaColeccion p)
        {
            return p.Mostrar();
        }

        public static implicit operator PaletaColeccion(int cantidad)
        {
            return new PaletaColeccion(cantidad); ;
        }

        public static bool operator ==(PaletaColeccion p, Tempera t)
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

        public static int operator ==(Tempera t, PaletaColeccion p)
        {
            int indice = -1;
            int contador = 0;
            foreach (Tempera item in p._colores)
            {
                if(t == item)
                {
                    indice = contador;
                }
                contador++;
            }
            return indice;
        }

        public static bool operator !=(PaletaColeccion p, Tempera t)
        {
            return !(p == t);
        }

        public static int operator !=(Tempera t, PaletaColeccion p)
        {
            return t == p;
        }

        public static PaletaColeccion operator +(PaletaColeccion p, Tempera t)
        {
            int indice = -1;
            if((t == p) != -1)
            {
                indice = (t == p);
                p._colores[indice] += t;
            }
            else
            {
                if (p._colores.Count < p._cantMaximaelementos)
                {
                    p._colores.Add(t);
                }
            }
            return p;
        }

        public static PaletaColeccion operator -(PaletaColeccion p, Tempera t)
        {
            int indice;
            sbyte aux1;
            sbyte aux2;
            indice = (t == p);
            if(indice != -1)
            {
                aux1 = (sbyte)t;
                p._colores[indice] += (sbyte)(aux1*(-1));
                aux2 = (sbyte)p._colores[indice];
                if(aux2<=0)
                {
                    p._colores.Remove(t);
                }
            }
            return p;
        }
        #endregion

        #region Indexador
        public Tempera this[int indice]
        {
            get
            {
                if(indice >= 0 && !(Object.Equals(this._colores[indice],null)) && indice < this._cantMaximaelementos)
                {
                    return this._colores[indice];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if(indice >= 0 && indice < this._cantMaximaelementos)
                {
                    this._colores[indice] = value;
                }
            }
        }
        #endregion
    }
}
