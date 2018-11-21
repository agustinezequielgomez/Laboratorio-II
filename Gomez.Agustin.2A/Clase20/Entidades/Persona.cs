using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }
        #endregion

        #region Constructor
        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
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
