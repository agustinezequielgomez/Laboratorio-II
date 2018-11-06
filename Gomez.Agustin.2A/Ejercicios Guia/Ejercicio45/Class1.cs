using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Class1
    {
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException(); //Lanzo la excepcion de DividedByZero
        }
    }
}
