using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class UnaException : Exception
    {
        public UnaException(string mensaje, Exception e) : base(mensaje,e) //Construyo UnaException pasandole los errores anteriores y la excepcion (Constructor heredado de Excepction)
        {
        }
    }
}
