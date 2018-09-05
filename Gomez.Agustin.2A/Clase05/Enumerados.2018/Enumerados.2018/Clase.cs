using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados._2018
{
    class Clase
    {
        public int entero;
        public MiEnumerado enumerado;

        public Clase(int entero, MiEnumerado a)
        {
            this.entero = entero;
            this.enumerado = a;
        }

        public void MetodoInstancia(MiEnumerado a)
        {
            Console.WriteLine(a);

            this.enumerado = (MiEnumerado)88;
        }
    }
}
