using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase07
{
    class Paleta
    {
        #region Atributos
        private Tempera[] _colores;
        private int _cantMaximaelementos;
        #endregion

        #region Constructor
        private Paleta() : this(5)
        {

        }

        private Paleta(int cantElementos)
        {
            this._cantMaximaelementos = cantElementos;
            this._colores = new Tempera[this._cantMaximaelementos];
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            string retorno = "Cantidad maxima de elementos: " + this._cantMaximaelementos + "\n\nColores utilizados en la paleta:\n ";
            string cadenaAux = "";
            foreach (Tempera temperas in this._colores)
            {
                cadenaAux += temperas;
            }
            retorno += cadenaAux;
            return retorno;
        }
        #endregion

        #region Sobrecarga
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad); ;
        }
        #endregion
    }
}
