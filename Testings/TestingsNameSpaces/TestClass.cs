using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingsNameSpaces
{
    public class Programo
    {
        private int[] _array;
        public int this[string indice]
        {
            get { return this._array[indice]; }
        }

        public Programo()
        {
            this._array = new int[100];
        }
    }
}
