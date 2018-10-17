using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Persona
    {
        private long dni;
        private string nombre;

        public long DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
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

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }

        public Persona(string nombre, long dni) : this(nombre)
        {
            this.DNI = dni;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}\nDNI: {1}", this.Nombre, this.DNI);
            return sb.ToString();
        }
    }
}
