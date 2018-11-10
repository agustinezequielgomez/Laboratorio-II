using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interfaz__Generics
{
    abstract class Class1 : Interface2
    {


        public bool algo()
        {
            return true;
        }

        public virtual string Funcion1()
        {
            throw new NotImplementedException();
        }

        public virtual int Funcion2()
        {
            throw new NotImplementedException();
        }
    }
}
