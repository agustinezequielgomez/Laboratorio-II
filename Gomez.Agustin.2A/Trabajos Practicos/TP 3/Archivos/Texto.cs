using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter stream = new StreamWriter(archivo, false))
                {
                    stream.Write(datos);
                    retorno = true;
                }
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }

        public bool Leer(string archivo, out string datos)
        {
            datos = "";
            bool retorno = false;
            try
            {
                using (StreamReader stream = new StreamReader(archivo))
                {
                    datos = stream.ReadToEnd();
                    retorno = true;
                }
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }
    }
}
