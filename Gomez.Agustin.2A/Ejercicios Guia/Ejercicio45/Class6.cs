using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Class6
    {
        public void MetodoInsatncia()
        {
            try
            {
               //Construyo una Class3
               new Class3();
            }
            catch(Exception e)//Atrapo UnaException lanzada por Class3 en su constructor
            {
                throw new MiException(e.Message + "\nError en MiException", e);//Construyo MiException con los datos de las Excepciones anteriores y la lanzo. Va a ser atrapada por lo que siga en el call stack.
            }
        }
    }
}
