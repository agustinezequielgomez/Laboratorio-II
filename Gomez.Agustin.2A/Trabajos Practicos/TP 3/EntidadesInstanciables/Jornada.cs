using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }

            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }

            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }

            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Constructor
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Clase = clase;
            this.instructor = instructor;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE {0} POR {1}", this.Clase, this.Instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno alumno in this.Alumnos)
            {
                sb.Append(alumno.ToString());
            }
            return sb.ToString();
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            return texto.Guardar((AppDomain.CurrentDomain.BaseDirectory + @"\Jornadas.txt"), jornada.ToString());
        }

        public static string Leer()
        {
            Texto texto = new Texto();
            string retorno = "";
            texto.Leer((AppDomain.CurrentDomain.BaseDirectory + @"\Jornadas.txt"), out retorno);
            return retorno;
        }
        #endregion

        #region Operadores
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if(j!=a)
            {
                j.Alumnos.Add(a);
            }
            else
            {
                //throw new AlumnoRepetidoException;
            }
            return j;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno alumno in j.Alumnos)
            {
                if(alumno == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        #endregion
    }
}
