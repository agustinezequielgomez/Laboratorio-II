using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Entidades {

    public class DepositoHeredado : Deposito, ISerializar, IDeserializar {

        public DepositoHeredado() : base() { }

        public bool Xml(string ruta) {

            TextWriter tw = new StreamWriter(ruta);

            try {

                XmlSerializer serializer = new XmlSerializer(typeof(DepositoHeredado));
                serializer.Serialize(tw, this);
                tw.Close();
                return true;

            } catch (Exception) {

                tw.Close();
                return false;

            }
            
        }

        bool IDeserializar.Xml(string ruta, out DepositoHeredado datos) {

            TextReader tr = new StreamReader(ruta);

            try {

                XmlSerializer serializer = new XmlSerializer(typeof(DepositoHeredado));
                datos = (DepositoHeredado)serializer.Deserialize(tr);
                tr.Close();
                return true;

            } catch (Exception) {

                tr.Close();
                datos = null;
                return false;

            }

        }

    }

}
