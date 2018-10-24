using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto,IAFIP
    {
        #region Atributos
        protected int _caballosFuerza;
        #endregion

        #region Propiedades
        public int CaballosFuerza
        {
            get
            {
                return this._caballosFuerza;
            }

            set
            {
                this._caballosFuerza = value;
            }
        }

        public double MiPropiedad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion

        #region Constructor
        public Deportivo(double precio, string patente, int hp) : base(precio,patente)
        {
            this._caballosFuerza = hp;
        }


        #endregion

        #region Metodos
        public double CalcularImpuesto()
        {
            return this.Precio * 0.28;
        }
        #endregion
    }
}
