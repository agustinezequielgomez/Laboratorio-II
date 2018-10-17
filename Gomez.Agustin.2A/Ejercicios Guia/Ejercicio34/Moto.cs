using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas,cantidadPuertas,color,cilindrada)
        {
            this.cilindrada = cilindrada;
        }
    }
}
