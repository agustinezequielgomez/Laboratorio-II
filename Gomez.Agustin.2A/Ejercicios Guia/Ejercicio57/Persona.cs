using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ejercicio57
{
    public class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        #endregion

        #region Propiedades
        public string _Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public string _Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }
        #endregion

        #region Constructor
        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        public static bool Guardar(Persona persona)
        {
            bool retorno = false;
            using (TextWriter writer = new StreamWriter("Persona.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                serializer.Serialize(writer, persona);
                retorno = true;
            }
            return retorno;
        }

        public static Persona Leer()
        {
            using (TextReader reader = new StreamReader("Persona.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                return (Persona)serializer.Deserialize(reader);
            }
        }

        public override string ToString()
        {
            return String.Format("\nNombre: {0}\nApellido: {1}\n", this.nombre, this.apellido);
        }
        #endregion
    }
}
