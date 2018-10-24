using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47Lib
{
    public class Torneo<T>  where T : Equipo 
    {
        #region Atributos
        private string nombre;
        private List<T> equipos;
        #endregion

        #region Propiedades
        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                return CalcularResultado(this.equipos[random.Next(0, this.equipos.Count)], this.equipos[random.Next(0, this.equipos.Count)]);
            }
        }
        #endregion

        #region Constructor
        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Torneo: {0}", this.nombre);
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularResultado(T equipo1, T equipo2)
        {
            Random random = new Random();
            return string.Format("[{0}][{1}]-[{2}][{3}]", equipo1.Nombre, random.Next(0,35), equipo2.Nombre, random.Next(0,35));
        }
        #endregion

        #region Operadores
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;
            foreach (T item in torneo.equipos)
            {
               if(item == equipo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo!=equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        #endregion
    }
}
