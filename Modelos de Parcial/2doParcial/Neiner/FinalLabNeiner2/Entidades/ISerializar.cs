using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializar
    {
        bool Xml(string path);
    }
    public interface IDeserializar
    {
        bool Xml(string path,out DepositoHeredado dp);
    }
}
