using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    interface IGuardar<T>
    {
        bool RutaDeArchivo { get; set; }
        bool Guardar();
        T Leer();
    }
}
