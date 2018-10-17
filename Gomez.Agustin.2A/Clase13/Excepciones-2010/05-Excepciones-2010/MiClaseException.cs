using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Excepciones_2010
{
    class MiClaseException : Exception
    {
        public MiClaseException()
            : base()
        {
        }

        public MiClaseException(string mensaje)
            : base(mensaje)
        {
        }

        public MiClaseException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }

        public override string ToString()
        {
            return "Mensaje de error: " + base.Message + "\nOrigen: " + base.Source;
        }

    }
}
