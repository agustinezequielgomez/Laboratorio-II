using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace EntidadesInstanciables
{
    public class Universidad
    {

        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
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

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }

            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }

            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                if(i >= 0 && i<this.Jornadas.Count)
                {
                    return this.Jornadas[i];
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if(i >= 0)
                {
                    this.Jornadas[i] = value;
                }
            }
        }
        #endregion

        #region Constructores
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }
        #endregion

        #region Metodos
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar("archivo.xml", uni);
        }

        public static Universidad Leer()
        {
            Universidad retorno = new Universidad();
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Leer("archivo.xml", out retorno);
            return retorno;
        }

        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("<-------------------------------------------------->");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno alumno in g.Alumnos)
            {
                if(a == alumno)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            foreach (Profesor profesor in g.Instructores)
            {
                if(profesor == i)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor profesor in u.Instructores)
            {
                if(profesor == clase)
                {
                    retorno = profesor;
                    break;
                }
            }

            if(retorno is null)
            {
                throw new SinProfesorException();
            }
            return retorno;
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor retorno = null;
            foreach (Profesor profesor in u.Instructores)
            {
                if(profesor!=clase)
                {
                    retorno = profesor;
                    break;
                }
            }
            return retorno;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada;
            Profesor profesor = (g == clase);
            if(!(profesor is null))
            {
                jornada = new Jornada(clase, profesor);
                foreach (Alumno alumno in g.Alumnos)
                {
                    if (alumno == clase)
                    {
                        jornada+=alumno;
                    }
                }
                g.Jornadas.Add(jornada);
            }
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u!=a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u!=i)
            {
                u.Instructores.Add(i);
            }
            return u;
        }
        #endregion
    }
}
