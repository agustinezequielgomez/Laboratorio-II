using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interfaz__Generics
{
    sealed class Class2 : Class1,Interface3,IComparable
    {
        public Class2()
        { }

        public Class2(int aasa)
        {

        }

        public int Algo => throw new NotImplementedException();

        public bool algo()
        {
            return true;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
