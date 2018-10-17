using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVuelas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadvueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVuelas = cantidadvueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            foreach (AutoF1 item in c.competidores)
            {
                if(item == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nCantidad de competidores: {0}\nCantidad de vueltas: {1}\nCompetidores: ", this.cantidadCompetidores, this.cantidadVuelas);
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendFormat(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();
            bool retorno = false;
            if(c.competidores.Count <= c.cantidadCompetidores)
            {
                if (c!=a)
                {
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVuelas;
                    a.CantidadCombustible = (short)random.Next(15, 100);
                    retorno = true;
                    c.competidores.Add(a); 
                }
            }
            return retorno;

        }
    }
}
