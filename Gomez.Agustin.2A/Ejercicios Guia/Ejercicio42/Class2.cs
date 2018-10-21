using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Class2 : Exception
    {
        public Class2()
        {
            try
            {
                //Voy al metodo Estatico de la Class1
                Class1.MetodoEstatico();
            }
            catch(Exception e) //Capturo la Excepcion
            {
                //La vuelvo a lanzar. Va a ser capturada por lo que siga en el call stack hacia arriba.
                throw e;
            }
        }
    }
}
