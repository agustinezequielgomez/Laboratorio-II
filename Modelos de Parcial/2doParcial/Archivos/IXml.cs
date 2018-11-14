using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    interface IXml<T>
    {
        bool Guardar(string ruta, T datos);
        bool Leer(string ruta, out T datos);
    }
}
