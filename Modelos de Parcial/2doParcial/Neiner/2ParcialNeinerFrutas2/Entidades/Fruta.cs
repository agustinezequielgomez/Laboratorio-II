using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public abstract class Fruta {

        protected ConsoleColor _color;
        protected float _peso;

        public abstract bool TieneCarozo { get; }

        public Fruta(float peso, ConsoleColor color) {

            this._peso = peso;
            this._color = color;

        }

        protected virtual string FrutaToString() {

            StringBuilder sb = new StringBuilder();

            sb.Append(this._color.ToString());
            sb.Append(" --- ");
            sb.Append(this._peso.ToString());

            return sb.ToString();

        } 

    }

}
