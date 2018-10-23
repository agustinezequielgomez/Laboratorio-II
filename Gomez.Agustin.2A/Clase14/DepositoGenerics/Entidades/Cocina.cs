using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        #region Atributos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion

        #region Propiedades
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }

        public double Precio
        {
            get
            {
                return this._precio;
            }
        }
        #endregion

        #region Constructor
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            return (obj is Cocina && this == (Cocina)obj);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Codigo: {0}", this.Codigo);
            sb.AppendFormat(" - Precio: {0}", this.Precio);
            sb.AppendFormat(" - Es industrial? {0}", this.EsIndustrial);
            return sb.ToString(); 
        }
        #endregion

        #region Operadores
        public static bool operator ==(Cocina a, Cocina b)
        {
            return (a.Codigo == b.Codigo);
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        #endregion
    }
}
