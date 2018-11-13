using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades {

    public class Manzana : Fruta, ISerializable {

        public string _distribuidora;

        public override bool TieneCarozo {

            get { return true; }

        }

        public string Tipo {

            get { return "Manzana"; }

        }

        public string RutaArchivo {

            get { return AppDomain.CurrentDomain.BaseDirectory + @"\Manzana.xml"; }
            set { ;}

        }

        public Manzana(float peso, ConsoleColor color, string distribuidora) : base(peso, color) {

            this._distribuidora = distribuidora;

        }

        public bool SerializarXML() {

            try {

                TextWriter tw = new StreamWriter(this.RutaArchivo);
                XmlSerializer serializador = new XmlSerializer(typeof(Manzana));
                serializador.Serialize(tw, this);
                tw.Close();
                return true;

            }
            catch (Exception) {

                return false;

            }

        }

        public bool Deserializar() {

            Manzana aux;

            try {	        
		
                TextReader tr = new StreamReader(this.RutaArchivo);
                XmlSerializer serializador = new XmlSerializer(typeof(Manzana));
                aux = (Manzana)serializador.Deserialize(tr);
                tr.Close();

                return true;

	        } catch (Exception) {
 
		        return false;
            
            }

        }

        protected override string FrutaToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(base.FrutaToString());
            sb.Append(" --- ");
            sb.Append(this.Tipo);
            sb.Append(" --- ");
            sb.Append(this._distribuidora);
            sb.Append(" --- ");
            sb.Append(this.TieneCarozo == true ? "SI" : "NO");

            return sb.ToString();

        }

        public override string ToString() {

            return this.FrutaToString();

        }

    }

}
