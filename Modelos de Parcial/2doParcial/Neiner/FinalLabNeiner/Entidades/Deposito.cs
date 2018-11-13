using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Entidades {

    [XmlInclude(typeof(DepositoHeredado))]
    public class Deposito {

        private Producto[] _productos;

        public Producto[] productos {

            get { return this._productos; }
            set { this._productos = value; }
                
        }

        public Deposito() :this(3) {

        }

        public Deposito(int cantidad) {

            this._productos = new Producto[cantidad];
                
        }

        public static Producto[] operator +(Deposito a, Deposito b) {

            Producto[] auxProductos = new Producto[3];
            Producto auxP;
            int index = 0;
            int indice;

            foreach (Producto i in a.productos) {

                if ((auxProductos == i) == -1) {

                    auxProductos[index] = i;
                    index++;

                } else {

                    indice = (auxProductos == i);
                    auxP = new Producto(i.nombre, auxProductos[indice].stock + i.stock);
                    auxProductos[indice] = auxP;

                }

            }

            foreach (Producto i in b.productos) {

                if ((auxProductos == i) == -1) {

                    auxProductos[index] = i;
                    index++;

                } else {

                    indice = (auxProductos == i);
                    auxP = new Producto(i.nombre, auxProductos[indice].stock + i.stock);
                    auxProductos[indice] = auxP;

                }

            }

            return auxProductos;

        }

        /*static int CantidadEntreAmbos(Deposito a, Deposito b) {

            int cantidad = a.productos.Length;
            bool esta = false;

            foreach (Producto i in b.productos) {

                foreach (Producto j in a.productos) {

                    if (i == j) {

                        esta = true;
                        break;

                    }

                }

                if (!esta) {

                    cantidad++;

                }

            }

            return cantidad;

        }*/

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            foreach (Producto i in this.productos) {

                sb.AppendLine(i.ToString());

            }

            return sb.ToString();

        }

    }

}
