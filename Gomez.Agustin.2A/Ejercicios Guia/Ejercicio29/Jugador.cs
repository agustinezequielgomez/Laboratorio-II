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
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
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

        public float GetPromedioGoles()
        {
            return this.promedioGoles = (float)(totalGoles / partidosJugados);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}\nDni: {1}", this.nombre, this.dni);
            sb.AppendFormat("\nPartidos Jugados: {0}\nPromedio de goles: {1}\nTotal de goles: {2}", this.partidosJugados, this.promedioGoles, this.totalGoles);
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
