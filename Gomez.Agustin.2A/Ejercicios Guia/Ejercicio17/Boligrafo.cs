using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta = tinta;
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            int i;
            bool retorno = false;
            dibujo = "";
            if (this.GetTinta() - gasto > 0)
            {
                for (i = 0; i<gasto; i++)
                {
                    dibujo += "*";
                    retorno = true;
                }
            }
            else
            {
                dibujo = "No hay tinta suficiente!!";
                retorno = false;
            }
            return retorno;
        }

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
    }
}
