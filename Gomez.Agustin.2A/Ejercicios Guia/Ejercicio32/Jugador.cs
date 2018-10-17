using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;


        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)(TotalGoles/PartidosJugados);
            }
        }

        public long DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
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
                this.nombre = value;
            }
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }


        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}\nDni: {1}", this.nombre, this.dni);
            sb.AppendFormat("\nPartidos Jugados: {0}\nPromedio de goles: {1}\nTotal de goles: {2}", this.partidosJugados, this.PromedioGoles, this.totalGoles);
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}
