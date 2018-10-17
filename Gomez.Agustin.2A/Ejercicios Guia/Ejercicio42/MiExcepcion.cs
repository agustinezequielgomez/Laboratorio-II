using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class MiExcepcion : Exception
    {
        public MiExcepcion()
        {
            try
            {
                new UnaExcepcion();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
