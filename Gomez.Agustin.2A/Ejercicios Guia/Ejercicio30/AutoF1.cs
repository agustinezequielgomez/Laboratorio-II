using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }

            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nEscuderia: {0}\nNumero: {1}\nEn competencia: {2}\nCantidad combustible: {3}\nVueltas restantes: {4}\n", this.escuderia, this.numero, this.EnCompetencia, this.CantidadCombustible, this.VueltasRestantes);
            return sb.ToString();
        }


        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.escuderia == a2.escuderia && a1.numero == a2.numero);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }
    }
}
