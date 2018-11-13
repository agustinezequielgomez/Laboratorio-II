using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public class Goma : Utiles {

        protected bool _soloLapiz;

        protected override string Marca {

            get { return this._marca; }
            set { this._marca = value; }

        }

        protected override float Precio {

            get { return this._precio; }
            set { this._precio = value; }

        }

        public Goma(bool soloLapiz, string marca, float precio) : base(precio, marca) {

            this._soloLapiz = soloLapiz;

        }

        protected override string UtilesToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat("Solo borra lapiz: {0}\n\n", this._soloLapiz == true ? "SI" : "NO");

            return sb.ToString();
        
        }

        public override string ToString() {

            return this.UtilesToString();

        }

    }

}
