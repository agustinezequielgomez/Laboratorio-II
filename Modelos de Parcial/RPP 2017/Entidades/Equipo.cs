using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public enum Deportes
        {
            Basquet,
            Handball,
            Futbol,
            Rugby
        }
        #endregion

        #region Propiedades
        public Deportes Deporte
        {
            set
            {
                this.deporte = value;
            }
        }
        #endregion
        
        #region Constructores
        private Equipo()
        {
            this.Deporte = Deportes.Futbol;
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt) : this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this(nombre,dt)
        {
            this.Deporte = deporte;

        }
        #endregion

        #region Operadores
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            foreach(Jugador jugador in e.jugadores)
            {
                if(j == jugador)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e!=j)
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if(e == j)
            {
                e.jugadores.Remove(j);
            }
            return e;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}\n", e.nombre,e.deporte);
            sb.AppendLine("Nomina de jugadores: ");
            foreach(Jugador jugador in e.jugadores)
            {
                sb.AppendLine(jugador.ToString());
            }
            sb.AppendFormat("Dirigido por: {0}", e.dt.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
