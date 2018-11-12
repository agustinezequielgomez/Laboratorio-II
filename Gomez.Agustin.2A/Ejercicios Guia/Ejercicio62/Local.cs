using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ejercicio62
{
    public class Local : Llamada, IGuardar<Local>
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Propiedades
        private string rutaDeArchivo;
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
            set
            {
                this.costo = value;
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }
        #endregion

        #region Constructores
        public Local() : base(0,"1","1")
        {
        }

        public Local(Llamada llamada, float precio) : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,precio)
        {
            
        }

        public Local(string origen, float duracion, string destino, float precio) : base(duracion, destino, origen)
        {
            this.costo = precio;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendFormat("Costo: {0}", this.CostoLlamada);
            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            using (TextWriter writer = new StreamWriter(this.RutaDeArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                serializer.Serialize(writer, this);
                return true;
            }
        }

        public Local Leer()
        {
            using (TextReader reader = new StreamReader(this.RutaDeArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                object obj = serializer.Deserialize(reader);
                if(obj is Local)
                {
                    return (Local)obj;
                }
                else
                {
                    throw new InvalidCastException();
                }
            }
        }
        #endregion
    }
}
