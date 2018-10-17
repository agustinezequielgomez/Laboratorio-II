using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;
 #region Propiedades
        public int CantidadDePaginas 
        {
            get
            {
                if(this._cantDePaginas==0)
                {
                    this._cantDePaginas = Libro._generadorDePaginas.Next(10, 580);
                }
                return this._cantDePaginas;
            }
        }
 #endregion
 #region Constructores
        static Libro()
        {
            Libro._generadorDePaginas=new Random();
        }
        public Libro(string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._precio = precio;
        }
        public Libro(float precio, string titulo, string nombre, string apellido)
            :this(titulo, new Autor(nombre,apellido),precio)
        {}
#endregion
 #region Metodos
        private static string Mostrar(Libro libro)
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendFormat("Titulo: {0}\nCantidad de paginas: {1}\nAutor: ", libro._titulo, libro.CantidadDePaginas);
            stringBuild.AppendLine(libro._autor);
            stringBuild.AppendFormat("Precio: {0:#.##}", libro._precio);

            return stringBuild.ToString();
        }
        public static explicit operator string(Libro libro)
        {
           return Libro.Mostrar(libro);
        }
        public static bool operator ==(Libro libroA, Libro libroB)
        {
            bool retorno = false;
            if (libroA._autor == libroB._autor && libroA._titulo == libroB._titulo)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Libro libroA, Libro libroB)
        {
            return !(libroA == libroB);
        }
 #endregion

    }
}
