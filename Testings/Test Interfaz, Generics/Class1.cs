using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interfaz__Generics
{
    abstract class Class1 : IComparable,Interface1,Interface2
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public virtual int Metodo();
    }
}
