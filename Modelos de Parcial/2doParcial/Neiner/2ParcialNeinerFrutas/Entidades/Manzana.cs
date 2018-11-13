using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Manzana:Fruta,ISerializable
    {
        public string distribuidora;

        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo
        {
            get { return "Manzana"; }
        }

        public string RutaArchivo { get; set; }

        protected override string FrutaToString()
        {
            return base.FrutaToString()+"/ Tipo :"+this.Tipo+"/ Distribuidora :"+this.distribuidora;
        }

        public Manzana():base(0,ConsoleColor.Red)
        {
            this.distribuidora = " ";
        }

        public Manzana(float peso, ConsoleColor color, string distribuidora)
            : base(peso, color)
        {
            this.distribuidora = distribuidora;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool SerializarXML()
        {
            try
            {
                this.RutaArchivo = "Manzana.xml";
                XmlSerializer serializador = new XmlSerializer(this.GetType());
                TextWriter escritor = new StreamWriter(this.RutaArchivo, false);
                serializador.Serialize(escritor, this);
                escritor.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Deserializar()
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(this.GetType());
                TextReader lector = new StreamReader(this.RutaArchivo);
                Console.WriteLine((serializador.Deserialize(lector)).ToString());
                lector.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
