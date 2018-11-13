using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void PrecioAlto(object sender, EventArgs ea);
    [Serializable]
    public class Cajon<T>:ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;
        public event PrecioAlto EventoPrecio;

        public List<T> Frutas 
        { 
            get{ return this._frutas; } 
        }

        public float PrecioTotal 
        {
            get 
            {
                if (_precioUnitario * this._frutas.Count > 25)
                {
                    this.EventoPrecio(this, EventArgs.Empty);
                }
                return _precioUnitario * this._frutas.Count; 
            }
        }

        public string RutaArchivo { get; set; }

        public Cajon()
        {
            this._capacidad = 0;
            this._frutas = new List<T>();
            this._precioUnitario = 0;
            this.EventoPrecio += new PrecioAlto(ImprimirTexto);
        }

        public Cajon(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio):this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public bool Deserializar()
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(this.GetType());
                TextReader lector = new StreamReader(this.RutaArchivo);
                Console.WriteLine(((Cajon<T>)serializador.Deserialize(lector)).ToString());
                lector.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c._frutas.Count + 1 <= c._capacidad)
            {
                c._frutas.Add(f);
                return c;
            }
            else
            {
                throw new CajonLlenoException("El cajon esta lleno");
            }
        }

        public bool SerializarXML()
        {
            try
            {
                this.RutaArchivo = "Cajon.xml";
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

        public static void ImprimirTexto(object obj, EventArgs ea)
        {
            try
            {
                TextWriter escritor = new StreamWriter("Precios.txt", true);
                escritor.WriteLine(DateTime.Now.ToString() + "/ Precio del Cajon: " + ((Cajon<Fruta>)obj).PrecioTotal.ToString());
                escritor.Close();
            }
            catch (Exception e)
            {

            }
        }

        public override string ToString()
        {
 	        StringBuilder sb=new StringBuilder();
            sb.AppendLine("CAJON / Capacidad: "+this._capacidad+"/ Precio unitario: "+this._precioUnitario+"/ Precio Total: "+this.PrecioTotal);
            foreach (T f in this._frutas)
            {
                sb.AppendLine(f.ToString());
            }
            return sb.ToString();
        }
    }
}
