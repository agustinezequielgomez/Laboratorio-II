using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class ExcepctionA
    {
        public ExcepctionA()
        {
            try
            {
                ThrowDivide.Metodo();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}

