using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class UnaExcepcion : Exception
    {
        public UnaExcepcion()
        {
            try
            {
                new ExcepctionA();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
