using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public class Platano : Fruta {

        public string _paisOrigen;

        public override bool TieneCarozo {

            get { return false; }
        
        }

        public string Tipo {

            get { return "Platano"; }
        
        }

        public Platano(float peso, ConsoleColor color, string pais) : base(peso, color) {

            this._paisOrigen = pais;

        }

        protected override string FrutaToString() {

            StringBuilder sb = new StringBuilder();

            sb.Append(base.FrutaToString());
            sb.Append(" --- ");
            sb.Append(this.Tipo);
            sb.Append(" --- ");
            sb.Append(this._paisOrigen);
            sb.Append(" --- ");
            sb.Append(this.TieneCarozo == true ? "SI" : "NO");

            return sb.ToString();

        }

        public override string ToString() {

            return this.FrutaToString();
        
        }

    }

}
