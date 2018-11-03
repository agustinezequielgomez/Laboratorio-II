using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            throw new NotImplementedException();
        }

        public bool Leer(string archivo, out T datos)
        {
            throw new NotImplementedException();
        }
    }
}
