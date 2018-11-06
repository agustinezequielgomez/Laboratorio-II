using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    class Boligrafo : IAcciones
    {
        #region Atributos
        private ConsoleColor colorTinta;
        private float tinta;
        #endregion
            
        #region Propiedades
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }

            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;

            }
        }
        #endregion

        #region Constructor
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, this.Color);
            this.UnidadesDeEscritura -= (float)(texto.Length * 0.3);
            return retorno;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            return String.Format("\nBoligrafo:\nColor: {0}\nCantidad de tinta: {1}\n", this.Color, this.UnidadesDeEscritura);
        }
        #endregion
    }
}
