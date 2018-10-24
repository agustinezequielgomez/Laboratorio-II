using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta : Vehiculo,IARBA
    {
        public Carreta(double precio) : base(precio)
        {
        }

        public double CalcularImpuesto()
        {
            return this.Precio*0.18;
        }
    }
}
