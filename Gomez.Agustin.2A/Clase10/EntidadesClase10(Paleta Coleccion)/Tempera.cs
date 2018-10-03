using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase10
{
    public class Tempera
    {
        #region Atributos
        private sbyte _cantidad;
        private ConsoleColor _color;
        private string _marca;
        #endregion

        #region Propiedades
        public string Marca {
            get
            {
                return this._marca;
            }
        }

        public sbyte Cantidad
        {
            get
            {
                return this._cantidad;
            }
        }

        public ConsoleColor Color
        {
            get
            {
                return this._color;
            }
        }
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
            return "\r\nMarca:" + this._marca + ". Color:" + this._color + ".Cantidad:" + this._cantidad;
        }

        public static int CompararNombre(Tempera t1, Tempera t2)
        {
            return string.Compare(t1.Marca, t2.Marca);
        }

        public static int CompararColor(Tempera t1, Tempera t2)
        {
            return string.Compare(Enum.GetName(typeof(ConsoleColor), t1.Color), Enum.GetName(typeof(ConsoleColor), t2.Color));
        }

        public static int CompararCantidad(Tempera t1, Tempera t2)
        {
            int retorno;
            if(t1.Cantidad > t2.Cantidad)
            {
                retorno = 1;
            }
            else if(t1.Cantidad < t2.Cantidad)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
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
