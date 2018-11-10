using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio58
{
    static class ArchivoTexto
    {
        public static bool Guardar(string path, string datos)
        {
            bool retorno = false;
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(datos);
                retorno = true;
            }
            return retorno;
        }

        public static string Leer(string path)
        {
            if(File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    return reader.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException("\nArchivo no encontrado", path);
            }
        }
    }
}
