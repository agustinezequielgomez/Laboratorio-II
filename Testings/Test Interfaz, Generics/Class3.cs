using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interfaz__Generics
{
    class Class3<U> : Interface1, Interface2 where U :Class1,Interface3,IComparable,new() 
    {
        public int MyProperty{ get; set; }

        public string Funcion1()
        {
            return "c";
        }

        public int Funcion2()
        {
            return 15;
        }

        string Interface2.Funcion1()
        {
            return "d";
        }

        public bool algo()
        {
            return true;
        }

        public T print<T>(T algo) where T : Class2
        {
            return algo;
        }

        public U Funcion1<U>() where U : Class1
        {
            throw new NotImplementedException();
        }

        int Interface1.Algo()
        {
            throw new NotImplementedException();
        }
    }
}
