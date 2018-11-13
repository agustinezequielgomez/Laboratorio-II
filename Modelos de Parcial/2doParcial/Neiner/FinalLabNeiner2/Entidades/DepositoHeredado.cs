using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Entidades
{
    public class DepositoHeredado : Deposito, ISerializar, IDeserializar
    {
        public DepositoHeredado()
        {

        }

        public bool Xml(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(DepositoHeredado));
                    xml.Serialize(sw, this);
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
           
        }

        bool IDeserializar.Xml(string path, out DepositoHeredado dp)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, false))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(DepositoHeredado));
                    dp=(DepositoHeredado)xml.Deserialize(sr);

                }
                    return true;
            }
            catch(Exception e)
            {
                dp = null;
                return false;
            }
        }
    }
}
