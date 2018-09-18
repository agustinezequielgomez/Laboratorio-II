using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores._2017
{
    class Libro
    {
        #region Atributos

        private string _titulo;
        private string _autor;
        private List<Capitulo> _capitulos;

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
                return this._capitulos.Count;
            }
        }
        #endregion

        #region Constructores

        public Libro(string titulo, string autor)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._capitulos = new List<Capitulo>();
        }

        #endregion

        #region Indexador

        public Capitulo this[int indice]
        {
            get
            {
                if (indice >= this._capitulos.Count || indice < 0)
                    return null;
                else
                    return this._capitulos[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._capitulos.Count)
                    this._capitulos[indice] = value;
                else if (indice == this._capitulos.Count)
                    this._capitulos.Add(value);
                else
                {
                    Console.WriteLine("No se puede asignar a este elemento");
                    Console.ReadLine();
                }
            }
        }

        #endregion
    }
}
