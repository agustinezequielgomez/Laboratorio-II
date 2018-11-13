using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public abstract class Utiles {

        protected float _precio;
        protected string _marca;

        protected abstract float Precio { get; set; }
        protected abstract string Marca { get; set; }

        public Utiles(float precio, string marca) {

            this._precio = precio;
            this._marca = marca;

        }

        protected virtual string UtilesToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca: " + this._marca);
            sb.Append("Precio: " + this._precio);

            return sb.ToString();

        }

    }

}
