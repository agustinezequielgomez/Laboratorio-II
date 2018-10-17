using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre): this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            bool retorno = true;
            if(e.jugadores.Count <= e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                     if(item == j)
                     {
                        retorno = false;
                        break;
                     }
                }
            }
            if(retorno == true)
            {
                e.jugadores.Add(j);
            }
            return e;
        }
    }
}
