using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public delegate void DelPares(object o, EventArgs e);

    public class Galpon<T> {

        private List<T> _elementos;
        private int _cantidad;
        public event DelPares ElementosPares;
        private EventArgs e = new EventArgs();

        private Galpon() {

            this._elementos = new List<T>();
            
        }

        public Galpon(int cantidad) : this() {

            this._cantidad = cantidad;

        }

        public void Add(T elemento) {

            if (this._elementos.Count < this._cantidad) {

                this._elementos.Add(elemento);
                if ((this._elementos.Count % 2) == 0) {

                    ElementosPares(this, this.e);

                }

            }

        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad: {0}\n", this._cantidad);
            sb.AppendLine("\nLista: \n");

            foreach (T i in this._elementos) {

                sb.AppendLine(i.ToString());

            }

            return sb.ToString();

        }

    }

}
