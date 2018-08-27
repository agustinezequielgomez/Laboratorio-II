using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            if(c == 'S' || c == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
