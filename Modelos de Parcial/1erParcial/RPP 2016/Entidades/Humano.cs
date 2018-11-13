using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano : Animal
    {
        #region Atributos
        private static int _piernas;
        private string _nombre;
        private string _apellido;
        #endregion

        #region Constructores
        static Humano()
        {
            Humano._piernas = 2;
        }

        public Humano(int velocidadMaxima) : base(Humano._piernas,velocidadMaxima)
        {
            this.VelocidadMaxima = velocidadMaxima;
        }

        public Humano(string nombre, string apellido, int velocidadMaxima) : this(velocidadMaxima)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        #endregion

        #region Metodos
        public string MostrarHumano()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("\n Nombre {0}\n Apellido{1}\n Cantidad de piernas {2}", this._nombre, this._apellido, Humano._piernas);
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Humano h1, Humano h2)
        {
            return (h1._nombre == h2._nombre && h1._apellido == h2._apellido);
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2); 
        }
        #endregion
    }
}
