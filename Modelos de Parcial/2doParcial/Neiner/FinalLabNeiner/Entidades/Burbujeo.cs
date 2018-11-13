using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Entidades {

    public class Burbujeo {

        public void MetodoInstancia() {

            StreamWriter sw = new StreamWriter("Burbujeo.txt", false);
            sw.WriteLine("En el metodo de instancia");
            sw.Close();
            throw new MiException();

        }

        public static void MetodoClase() {

            try {

                new Burbujeo().MetodoInstancia();

            } catch (MiException) {

                StreamWriter sw = new StreamWriter("Burbujeo.txt", true);
                sw.WriteLine("En el metodo estatico");
                sw.Close();
                throw new MiException();
            }

        }

    }

}
