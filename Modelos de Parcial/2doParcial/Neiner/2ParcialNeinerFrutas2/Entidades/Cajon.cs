using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using Exceptions;
using Interfaces;
using EventArgsClases;

namespace Entidades {

    public delegate void CajonDelegado(object o, PrecioEventArgs e);

    public class Cajon<T> : ISerializable {

        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;

        private string _rutaArchivo = AppDomain.CurrentDomain.BaseDirectory;

        public event CajonDelegado EventoPrecio;

        #region PROPIEDADES

        public List<T> Frutas {

            get { return this._frutas; }
        
        }

        public float PrecioTotal {

            get { 
                
                float total = this.Frutas.Count * this._precioUnitario;
                if (total > 25) {
                    PrecioEventArgs e = new PrecioEventArgs();
                    e.PrecioTotal = total;
                    EventoPrecio((object)this, e);
                }

                return total;
            
            }
            
        }

        public string RutaArchivo {

            get { return this._rutaArchivo; }
            set { this._rutaArchivo = value; }

        }

        #endregion PROPIEDADES

        private Cajon() {

            this._frutas = new List<T>();

        }

        public Cajon(int capacidad) : this() {

            this._capacidad = capacidad;
            this._precioUnitario = 3;

        }

       public Cajon(int capacidad, float precio) : this(capacidad) {

            this._precioUnitario = precio;

        }

        public bool SerializarXML() {

            try {

                TextWriter tw = new StreamWriter(this.RutaArchivo);
                XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));
                serializador.Serialize(tw, this);
                tw.Close();
                return true;

            } catch (Exception) {

                return false;

            }

        }

        public bool Deserializar() {

            Cajon<T> aux;

            try {	        
		
                TextReader tr = new StreamReader(this.RutaArchivo);
                XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));
                aux = (Cajon<T>)serializador.Deserialize(tr);
                tr.Close();

                return true;

	        } catch (Exception) {
 
		        return false;
            
            }

        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad: {0}\n", this._capacidad);
            sb.AppendFormat("Cantidad de frutas: {0}\n", this.Frutas.Count);
            sb.AppendFormat("Precio total: {0}\n\n", this.PrecioTotal);
            sb.AppendFormat("Listado de frutas:\n\n");

            foreach (T i in this.Frutas) {

                sb.AppendLine(i.ToString());

            }

            return sb.ToString();

        }

        public static Cajon<T> operator + (Cajon<T> c, T f) {

            Cajon<T> auxCajon = c;

            try {

                if (auxCajon.Frutas.Count < auxCajon._capacidad) {

                    auxCajon.Frutas.Add(f);

                } else {

                    throw new CajonLlenoException("No se pudo agregar la fruta al cajon. El mismo esta lleno.");

                }

            } catch (CajonLlenoException e) {

                Console.WriteLine(e.Message);

            }

            return auxCajon;
        }

    }

}
