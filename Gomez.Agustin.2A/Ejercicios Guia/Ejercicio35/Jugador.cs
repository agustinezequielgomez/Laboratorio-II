using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;


        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }

            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }

            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)(TotalGoles/PartidosJugados);
            }
        }

     
        private Jugador(string nombre, int totalGoles, int totalPartidos) : base(nombre)
        {
            this.PartidosJugados = totalPartidos;
            this.TotalGoles = totalGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.MostrarDatos());
            sb.AppendFormat("\nPartidos Jugados: {0}\nPromedio de goles: {1}\nTotal de goles: {2}", this.PartidosJugados, this.PromedioGoles, this.TotalGoles);
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.DNI == j2.DNI);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.DNI == j2.DNI);
        }
    }
}
