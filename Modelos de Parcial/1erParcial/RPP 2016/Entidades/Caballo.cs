using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Caballo : Animal
    {
        #region Atributos
        private string _nombre;
        private static int _patas;
        #endregion

        #region Constructores
        static Caballo()
        {
            Caballo._patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima) : base(Caballo._patas,velocidadMaxima)
        {
            this._nombre = nombre;
        }
        #endregion

        #region Metodos
        public string MostrarCaballo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("\n Nombre {0}\n  Cantidad de patas {1}", this._nombre, Caballo._patas);
            return sb.ToString();
        }

        #endregion

        #region Operadores
        public static bool operator ==(Caballo c1, Caballo c2)
        {
            return (c1._nombre == c2._nombre);
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}
