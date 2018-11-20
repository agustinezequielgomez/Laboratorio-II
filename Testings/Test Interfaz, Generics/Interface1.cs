using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interfaz__Generics
{
    interface Interface1
    {
        T Funcion1<T>() where T : Class1;
        int Funcion2();
        static int Algo();
    }
}
