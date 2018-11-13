using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public class Lapicera : Utiles {

        protected ConsoleColor _color;
        protected string _trazo;

        protected override string Marca {

            get { return this._marca; }
            set { this._marca = value; }

        }

        protected override float Precio {
            
            get { return this._precio; }
            set { this._precio = value; }
        
        }

        public Lapicera(ConsoleColor color, string trazo, string marca, float precio) : base(precio, marca) {

            this._color = color;
            this._trazo = trazo;

        }

        protected override string UtilesToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendLine("Color: " + _color.ToString());
            sb.AppendLine("Trazo: " + _trazo + "\n");

            return sb.ToString();
        
        }

        public override string ToString() {

            return this.UtilesToString();

        }

    }

}
