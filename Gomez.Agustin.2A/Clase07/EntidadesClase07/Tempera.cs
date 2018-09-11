using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase07
{
    class Tempera
    {
        #region Atributos
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;
        #endregion

        #region Constructor
        public Tempera(sbyte cant, ConsoleColor color, string marca)
        {
            this._cantidad = cant;
            this._color = color;
            this._marca = marca;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "Marca: " + this._marca + "\nColor: " + this._color + "\nCantidad: " + this._cantidad;
        }
        #endregion

        #region Sobrecargas
        public static implicit operator string(Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static explicit operator sbyte(Tempera tempera)
        {
            return tempera._cantidad;
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            return (t1._color == t2._color) && (t1._marca == t2._marca); 
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t1, sbyte cant)
        {
            t1._cantidad += cant;
            return t1;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera t3 = new Tempera(t1._cantidad,t1._color,t1._marca);

            if (t1 == t2)
            {
                t3 += t2._cantidad;
            }
            return t3;

        }
        #endregion
    }
}
