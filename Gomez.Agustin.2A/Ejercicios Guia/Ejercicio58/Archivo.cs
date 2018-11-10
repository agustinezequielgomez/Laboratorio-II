using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio58
{
    [Serializable]
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta)
        {
            if(File.Exists(ruta))
            {
                return true;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
