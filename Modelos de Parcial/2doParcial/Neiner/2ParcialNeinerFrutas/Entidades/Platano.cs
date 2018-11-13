using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Platano:Fruta
    {
        public string paisOrigen;

        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo
        {
            get { return "Platano"; }
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString()+"/ Tipo :"+this.Tipo+"/ Pais de Origen :"+this.paisOrigen;
        }

        public Platano()
            : base(0, ConsoleColor.Yellow)
        {
            this.paisOrigen = " ";
        }

        public Platano(float peso, ConsoleColor color, string pais)
            :base(peso,color)
        {
            this.paisOrigen = pais;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
