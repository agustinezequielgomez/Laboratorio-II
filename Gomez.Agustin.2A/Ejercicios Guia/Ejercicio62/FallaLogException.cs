using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio62
{
    class FallaLogException : Exception
    {
        public FallaLogException(string mensaje) : base(mensaje)
        {

        }
    }
}
