using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase05
{
    class Tinta
    {
        #region Atributos

        private ConsoleColor _color;
        private ETipoTinta _tipo;
        #endregion

        #region Constructores
        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.conBrillito;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }
        #endregion

        #region Metodos
        public static string Mostrar(Tinta objeto)
        {
            return objeto.Mostrar();

        }

        private string Mostrar()
        {
            return "Color: " + this._color.ToString() + "\nTinta: " + this._tipo.ToString();
        }

        public static bool operator ==(Tinta obj1, Tinta obj2)
        {
            if(obj1._color == obj2._color && obj1._tipo == obj2._tipo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta obj1, Tinta obj2)
        {
            return !(obj1 == obj2);
        }

        #endregion
    }
}
