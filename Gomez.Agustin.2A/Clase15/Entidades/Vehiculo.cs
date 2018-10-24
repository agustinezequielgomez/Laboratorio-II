using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region Atributos
        protected double _precio;
        #endregion

        #region Propiedades
        public double Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }
        #endregion

        #region Constructor
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        #endregion

        #region Metodos
        public void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
        #endregion
    }
}
