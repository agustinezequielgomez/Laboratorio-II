using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    interface ITexto
    {
        bool Guardar(string ruta, string datos);
        bool Leer(string ruta, out string datos);
    }
}
