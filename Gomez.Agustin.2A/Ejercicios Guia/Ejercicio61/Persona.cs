using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    class Persona
    {
        #region Atributos
        public int id;
        public string nombre;
        public string apellido;
        #endregion

        #region Constructor
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int id):this(nombre,apellido)
        {
            this.id = id;
        }
        #endregion
    }
}
