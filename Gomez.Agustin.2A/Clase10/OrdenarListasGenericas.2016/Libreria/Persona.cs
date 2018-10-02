using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Persona
    {
        #region Atributos
        private string _apellido;
        private string _nombre;
        private int _dni;
        #endregion

        #region Propiedades

        public string Apellido
        {
            get { return _apellido; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        public int DNI
        {
            get { return _dni; }
        }

        #endregion

        #region Constructor
        public Persona(string apellido, string nombre, int dni)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._nombre = nombre;
        }
        #endregion

        #region Métodos Estáticos
        /// <summary>
        /// Ordena Personas por número de DNI (Asc.)
        /// </summary>
        /// <param name="a">Primera Persona</param>
        /// <param name="b">Segunda Persona</param>
        /// <returns></returns>
        public static int OredenaPersonasPorDni(Persona a, Persona b)
        {
            int retorno = 0;

            if (a._dni > b._dni)
            {
                retorno = 1;
            }
            if (a._dni < b._dni)
            {
                retorno = -1;
            }

            return retorno;
        }
        /// <summary>
        /// Ordena Personas por Apellido
        /// </summary>
        /// <param name="a">Primera Persona</param>
        /// <param name="b">Segunda Persona</param>
        /// <returns></returns>
        public static int OredenaPersonasPorApellido(Persona a, Persona b)
        {
            int retorno = 0;
            if (String.Compare(a._apellido, b._apellido) < 0)
            {
                retorno = -1;
            }
            if (String.Compare(a._apellido, b._apellido) > 0)
            {
                retorno = 1;
            }

            return retorno;
        }
        /// <summary>
        /// Ordena Personas por Nombre
        /// </summary>
        /// <param name="a">Primera Persona</param>
        /// <param name="b">Segunda Persona</param>
        /// <returns></returns>
        public static int OredenaPersonasPorNombre(Persona a, Persona b)
        {
            int retorno = 0;

            if (a._nombre.CompareTo(b._nombre) < 0)
            {
                retorno = -1;
            }
            if (a._nombre.CompareTo(b._nombre) > 0)
            {
                retorno = 1;
            }

            return retorno;
        }

        /// <summary>
        /// Muestra listado de personas
        /// </summary>
        /// <param name="lista">Personas a mostrar</param>
        /// <returns></returns>
        public static string MostrarLista(List<Persona> lista)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("******************************************************");

            foreach (Persona p in lista)
                sb.AppendLine(p.ToString());

            sb.AppendLine("******************************************************");
            
            return sb.ToString();
        }

        #endregion

        #region Métodos de Instancia. Polimorfismo

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.Append("Apellido: ");
            sb.Append(this._apellido);
            sb.Append(" - ");

            sb.Append("Nombre: ");
            sb.Append(this._nombre);
            sb.Append(" - ");

            sb.Append("DNI: ");
            sb.Append(this._dni);


            return sb.ToString();
        }

        #endregion

    }
}
