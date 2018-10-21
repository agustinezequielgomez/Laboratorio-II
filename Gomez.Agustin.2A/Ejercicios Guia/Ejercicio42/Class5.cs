using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class MiException : Exception
    {

        public MiException(string mensaje, Exception e) : base(mensaje, e)
        {

        }
    }
}
