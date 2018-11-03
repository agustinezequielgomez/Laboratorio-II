using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }

            set
            {
                try
                {
                    this.dni = this.ValidarDni(this.Nacionalidad, value);
                }
                catch(Exception e)
                {

                }
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
               return this.nacionalidad;
            }

            set
            {
                this.nacionalidad = value;
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
                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        public string StringToDNI
        {
            set
            {
                try
                {
                     this.DNI = ValidarDni(this.Nacionalidad, value);
                }
                catch(Exception e)
                {

                }
            }
        }
        #endregion

        #region Constructores
        public Persona() : this("Sin nombre","Sin Apellido",ENacionalidad.Argentino)
        {
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("NOMBRE COMPLETO: {0} {1}", this.Apellido, this.Nombre);
            sb.AppendFormat("\nNACIONALIDAD: {0}\n", Enum.GetName(typeof(ENacionalidad),this.Nacionalidad));
            return sb.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato > 1 && dato < 89999999)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        //throw NacionalidadInvalidaException
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato >= 90000000 && dato <= 99999999)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        //throw NacionalidadInvalidaException
                    }
                    break;
                default:
                    break;
            }
            return retorno;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            int retorno = 0;
            if (dato.Length <= 8 && (int.TryParse(dato, out dni)))
            {
                retorno = dni;
            }
            else
            {
                //throw DniInvalidoException
            }
            return retorno;
        }

        private string ValidarNombreApellido(string dato)
        {
            bool flag = true;
            string retorno = "";
            foreach (char item in dato)
            {
                if (!(Char.IsLetter(item)))
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true)
            {
                retorno = dato;
            }
            else
            {
                retorno = "";
            }
            return retorno;
        }
        #endregion
    }
}
