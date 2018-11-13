using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool validar(int x,int y, int z)
        {
            bool devolver = false;
            if(y>x && y<z)
            {
                devolver = true;
            }
            return devolver;
        }
    }
}
