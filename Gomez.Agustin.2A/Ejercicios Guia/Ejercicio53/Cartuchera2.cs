using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio53
{
    class Cartuchera2
    {
        #region Atributos
        public List<Lapiz> lapiz;
        public List<Boligrafo> boligrafos;
        #endregion

        #region Constructor
        public Cartuchera2()
        {
            this.lapiz = new List<Lapiz>();
            this.boligrafos = new List<Boligrafo>();
        }
        #endregion

        #region Metodos
        public bool ProbarElementos()
        {
            bool retorno = true;
            foreach (Lapiz item in this.lapiz)
            {
                if (((IAcciones)item).UnidadesDeEscritura - 1 > 0)
                {
                    ((IAcciones)item).UnidadesDeEscritura = -1;
                }
                else if (((IAcciones)item).UnidadesDeEscritura - 1 == 0)
                {
                    ((IAcciones)item).UnidadesDeEscritura -= 1;
                    ((IAcciones)item).Recargar(5);
                }
                else
                {
                    retorno = false;
                }
            }
            foreach (Boligrafo item in this.boligrafos)
            {
                if (item.UnidadesDeEscritura - 1 > 0)
                {
                    item.UnidadesDeEscritura = -1;
                }
                else if (item.UnidadesDeEscritura - 1 == 0)
                {
                    item.UnidadesDeEscritura -= 1;
                    item.Recargar(5);
                }
                else
                {
                    retorno = false;
                }
            }
            return retorno;
        }
        #endregion
    }
}
