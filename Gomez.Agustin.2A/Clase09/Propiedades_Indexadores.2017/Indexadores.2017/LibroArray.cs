using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores._2017
{
    class LibroArray
    {
         #region Atributos

        private string _titulo;
        private string _autor;
        private Capitulo[] _capitulos;

        #endregion

        #region Propiedades

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public string Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }

        public int CantidadDeCapitulos
        {
            get
            {
                return this._capitulos.GetLength(0);
            }
        }

        #endregion

        #region Constructores

        public LibroArray(string titulo, string autor)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._capitulos = new Capitulo[0];
        }

        #endregion

        #region Indexador

        public Capitulo this[int indice]
        {
            get
            {
                if (indice >= this._capitulos.GetLength(0) || indice < 0)
                    return null;
                else
                    return this._capitulos[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._capitulos.GetLength(0))
                    this._capitulos[indice] = value;
                else if (indice == this._capitulos.GetLength(0)){

                    this._capitulos = this + indice;
                    this[indice] = value;
                }
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }

        public static Capitulo[] operator +(LibroArray libro, int indice)
        {
            int i = indice >= libro._capitulos.GetLength(0) ? ++indice : --indice;

            Capitulo[] aux = new Capitulo[i];

            libro._capitulos.CopyTo(aux, 0);

            return aux;
 
        }
        #endregion
    }
}
