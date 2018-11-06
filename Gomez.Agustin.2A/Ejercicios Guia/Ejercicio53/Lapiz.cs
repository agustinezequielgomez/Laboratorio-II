using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    class Lapiz : IAcciones
    {
        #region Atributos
        private float tamanioMina;
        #endregion

        #region Propiedades
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set => throw new NotImplementedException();
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        #endregion

        #region Constructor
        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        #endregion

        #region Metodos
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            EscrituraWrapper retorno = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            ((IAcciones)this).UnidadesDeEscritura -= (float)(texto.Length * 0.1);
            return retorno;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return String.Format("\nLapiz:\nColor: {0}\nTamaño mina: {1}", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura);
        }
        #endregion
    }
}
