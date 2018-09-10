using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase06WF
{
    class Pluma
    {
        #region Atributos
        private string _marca;
        private int _cantidad;
        private Tinta _tinta;
        #endregion

        #region Constructores
        public Pluma()
        {
            this._marca = "Sin marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca): this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, int cantidad) : this(marca)
        {
            this._cantidad = cantidad;
        }

        public Pluma(string marca, int cantidad, Tinta tinta) : this(marca,cantidad)
        {
            this._tinta = tinta;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string cadena;
            cadena = "Marca: " + this._marca + "\nCantidad: " + this._cantidad + "\n" + Tinta.Mostrar(this._tinta);
            return cadena;
        }

        public static implicit operator string(Pluma objeto)
        {
            return objeto.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
                 if (!(Object.Equals(tinta, null))&&pluma._tinta == tinta)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(!(Object.Equals(tinta, null))&&pluma == tinta)
            {
                if(pluma._cantidad >= 90)
                {
                    pluma._cantidad = pluma._cantidad + (100 - pluma._cantidad);
                }
                else
                {
                    pluma._cantidad += 10;
                }
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if(!(Object.Equals(tinta, null))&&(pluma == tinta))
            {
                if(pluma._cantidad - 15 <= 0)
                {
                    pluma._cantidad = 0;
                }
                else
                {
                    pluma._cantidad -= 15;
                }
            }
            return pluma;
        }
        #endregion
    }
}
