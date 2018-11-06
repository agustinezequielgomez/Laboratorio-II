using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Class3 : Exception
    {
        public Class3()
        {
            try
            {
               //Construyo una Class2
               new Class2();
            }
            catch(Exception d) //Capturo la excepcion lanzada por Class2
            {
                throw new UnaException(d.Message + "\nError en UnaException", d);//Construyo UnaException pasandole los errores anteriores y la excepcion y la lanzo. Va a ser atrapada por lo que siga en el call stack.
            }
        }
    }
}
