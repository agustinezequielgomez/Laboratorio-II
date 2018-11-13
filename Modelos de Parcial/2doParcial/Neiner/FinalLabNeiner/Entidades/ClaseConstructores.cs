using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Entidades {

    public class ClaseConstructores {

        private int datoUno;
        private int datoDos;

        public int DatoUno {

            get {
                MessageBox.Show("En propiedad lectura");
                return this.datoUno;
            }

        }

        public int DatoDos {

            set {
                MessageBox.Show("En propiedad escritura");
                this.datoDos = value;
            }

        }

        static ClaseConstructores() {

            MessageBox.Show("En constructor estatico");

        }

        public ClaseConstructores() : this(1,2) {

            MessageBox.Show("En constructor por defecto");
            this.DatoDos = 5;
            this.datoDos = this.DatoUno * 5;
            InicioInstancia();

        }

        private ClaseConstructores(int d1, int d2) {

            MessageBox.Show("En constructor parametrizado");
            this.datoUno = d1;
            this.datoDos = d2;

        } 

        static void Inicio() {

            MessageBox.Show("En metodo de clase");

        }

        private void InicioInstancia() {

            MessageBox.Show("En metodo de instancia");
            Inicio();

        }

    }

}
