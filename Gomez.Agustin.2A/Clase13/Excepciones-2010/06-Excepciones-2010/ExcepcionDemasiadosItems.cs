using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Excepciones_2010
{
    public class ExcepcionDemasiadosItems : Exception
    {
        public ExcepcionDemasiadosItems()
            : base("Demasiados items")
        {
        }
    }
}
