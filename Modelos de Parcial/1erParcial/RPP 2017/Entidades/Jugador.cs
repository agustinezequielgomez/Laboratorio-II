using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private bool esCapitan;
        private int numero;
        #endregion

        #region Propiedades
        public bool EsCapitan
        {
            get
            {
                return this.esCapitan;
            }
            set
            {
                this.esCapitan = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        #endregion

        #region Constructores
        public Jugador(string nombre, string apellido) : this(nombre, apellido,0,false)
        {

        }

        public Jugador(string nombre, string apellido, int numero, bool esCapitan) :  base(nombre, apellido)
        {
            this.Numero = numero;
            this.EsCapitan = esCapitan;
        }
        #endregion

        #region Metodos
        protected override string FichaTecnica()
        {
            StringBuilder sb = new StringBuilder();
            if(this.EsCapitan == true)
            {
                sb.Append(base.NombreCompleto());
                sb.AppendFormat(", capitan del equipo, camiseta numero {0}\n",this.Numero);
            }
            else
            {
                sb.Append(base.NombreCompleto());
                sb.AppendFormat(", camista numero {0}\n", this.Numero);
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        public override bool Equals(object obj)
        {
            return (this == (Jugador)obj);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Numero == j2.Numero && j1.Apellido == j2.Apellido);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }
        #endregion
    }
}
