using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;
 #region Constructores
        private Biblioteca()
        {
            _libros = new List<Libro>();
        }
        private Biblioteca(int capacidad)
            :this()
        {
            this._capacidad = capacidad;
        }
        #endregion
 #region Propiedades
        public double PrecioDeManuales
        { 
            get 
            { 
                return this.ObtenerPrecio(ELibro.Manual); 
            } 
        }

        public double PrecioDeNovelas
        {
            get 
            { 
                return this.ObtenerPrecio(ELibro.Novela); 
            } 
        }

        public double PrecioTotal
        { 
            get 
            { 
                return (this.ObtenerPrecio(ELibro.Novela) + this.ObtenerPrecio(ELibro.Manual)); 
            } 
        }

        #endregion
 #region Metodos
        public static string Mostrar(Biblioteca biblioteca)
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendFormat("Capacidad de la biblioteca: {0}\n", biblioteca._capacidad);
            stringBuild.AppendFormat("Total por Manuales: $ {0:#.##}\n", biblioteca.PrecioDeManuales);
            stringBuild.AppendFormat("Total por Novelas: $ {0:#.##}\n", biblioteca.PrecioDeNovelas);
            stringBuild.AppendFormat("Total: $ {0:#.##}\n", biblioteca.PrecioTotal);
            stringBuild.AppendLine("****************************************");
            stringBuild.AppendLine("Listado de Libros");
            stringBuild.AppendFormat("****************************************");

            foreach (Libro libro in biblioteca._libros)
            {
                stringBuild.AppendLine("");
                if (libro is Manual)
                { stringBuild.AppendLine(((Manual)libro).Mostrar()); }
                else if (libro is Novela)
                { stringBuild.AppendLine(((Novela)libro).Mostrar()); }
            }

            return stringBuild.ToString();
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double retorno = 0;

            foreach (Libro libro in this._libros)
            {
                switch (tipoLibro)
                {
                    case ELibro.Manual:
                        if (libro is Manual)
                        { 
                            retorno += ((Manual)libro); 
                        }
                        break;
                    case ELibro.Novela:
                        if (libro is Novela)
                        { 
                            retorno += ((Novela)libro); 
                        }
                        break;
                    default:
                        break;
                }
            }

            return retorno;
        }
        public static implicit operator Biblioteca(int capacidad)
        { 
            return (new Biblioteca(capacidad)); //Retorna instancia de Biblioteca que coincide con el param recibido.
        }
 #endregion
 #region Operadores
        public static Boolean operator ==(Biblioteca biblioteca, Libro libro)
        {
            Boolean retorno = false;

            foreach (Libro libroA in biblioteca._libros)
            {
                if (libro is Novela && libroA is Novela)
                {
                    if (((Novela)libroA) == ((Novela)libro))
                    {
                        retorno = true;
                        break;
                    }
                }
                else if (libro is Manual && libroA is Manual)
                {
                    if (((Manual)libroA) == ((Manual)libro))
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static Boolean operator !=(Biblioteca biblioteca, Libro libro)
        {
            return !(biblioteca == libro);
        }
        public static Biblioteca operator +(Biblioteca biblioteca, Libro libro)
        {
            if (biblioteca._libros.Count < biblioteca._capacidad)
            {
                if (biblioteca != libro)
                { biblioteca._libros.Add(libro); }
                else
                { Console.WriteLine("El libro ya está en la biblioteca!!!"); }
            }
            else
            { Console.WriteLine("No hay más lugar en la biblioteca!!!"); }
            return biblioteca;
        }

 #endregion
    }
}
public enum ELibro
{
    Manual,
    Novela,
    Ambos,
}
