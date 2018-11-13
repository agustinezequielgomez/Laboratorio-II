using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Platano))]
    [XmlInclude(typeof(Manzana))]
    [Serializable] 
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public abstract bool TieneCarozo { get; }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return "Color :" + this._color + "/ Peso :" + this._peso + "/ Tiene carozo :" + this.TieneCarozo;
        }
    }
}
