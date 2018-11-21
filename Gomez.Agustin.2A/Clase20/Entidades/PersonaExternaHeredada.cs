using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Entidades
{
    public class PersonaExternaHeredada : PersonaExterna
    {
        #region Propiedades
        public string Nombre
        {
            get
            {
                return base._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return base._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return base._edad;
            }
        }

        public Externa.ESexo Sexo
        {
            get
            {
                return base._sexo;
            }
        }
        #endregion

        #region Constructor
        public PersonaExternaHeredada(string nombre, string apellido, int edad, Externa.ESexo sexo) : base(nombre,apellido,edad,sexo)
        {
        }
        #endregion

        #region Metodos
        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}\n", this.Nombre);
            sb.AppendFormat("Apellido: {0}\n", this.Apellido);
            sb.AppendFormat("Edad: {0}\n", this.Edad);
            sb.AppendFormat("Sexo: {0}\n", this.Sexo);
            return sb.ToString();
        }
        #endregion

    }
}
