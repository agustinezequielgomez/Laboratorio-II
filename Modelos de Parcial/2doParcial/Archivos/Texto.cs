using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Texto : ITexto
    {
        public bool Guardar(string ruta, string datos)
        {
            bool retorno = false;
            using (StreamWriter writer = new StreamWriter(ruta, false))
            {
                writer.Write(datos);
                retorno = true;
            }
            return retorno;
        }

        public bool Leer(string ruta, out string datos)
        {
            bool retorno = false;
            using (StreamReader reader = new StreamReader(ruta))
            {
                datos = reader.ReadToEnd();
                retorno = true;
            }
            return retorno;
        }
    }
}
