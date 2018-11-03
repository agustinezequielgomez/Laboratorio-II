using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            try
            {
                using (TextWriter writer = new StreamWriter(archivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            try
            {
                using (TextReader reader = new StreamReader(archivo))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    datos = (T) xml.Deserialize(reader);
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
