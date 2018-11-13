using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Perro : Animal
    {
        #region Atributes
        private static int _patas;
        private Razas _raza;

        public enum Razas
        {
            Galgo,
            OvejeroAleman
        }
        #endregion

        #region Constructores
        static Perro()
        {
            Perro._patas = 4;
        }

        public Perro(int velocidadMaxima) : this(velocidadMaxima,Razas.Galgo)
        {

        }

        public Perro(int velocidadMaxima, Razas raza) : base (Perro._patas,velocidadMaxima)
        {
            this.VelocidadMaxima = velocidadMaxima;
            this._raza = raza;
        }
        #endregion

        #region Metodos
        public string MostrarPerro()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("\n Patas {0}\n Raza{1}\n", Perro._patas, this._raza);
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Perro p1, Perro p2)
        {
            return (p1._raza == p2._raza && p1._velocidadMaxima == p2._velocidadMaxima);
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}
