using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    public interface ISerializable {

        string RutaArchivo { get; set; }

        bool SerializarXML();
        bool Deserializar();

    }

}
