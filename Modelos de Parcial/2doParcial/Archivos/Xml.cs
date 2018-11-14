using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Archivos
{
    class Xml<T> : IXml<T>
    {
        public bool Guardar(string ruta, T datos)
        {
            bool retorno = false;
            using (TextWriter writer = new StreamWriter(ruta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
                retorno = true;
            }
            return retorno;
        }

        public bool Leer(string ruta, out T datos)
        {
            bool retorno = false;
            using (TextReader reader = new StreamReader(ruta))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                datos = (T) serializer.Deserialize(reader);
                retorno = true;
            }
            return retorno;
        }
    }
}
