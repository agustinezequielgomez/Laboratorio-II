using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgsClases {

    public class PrecioEventArgs : EventArgs {

        private float _precioTotal;

        public float PrecioTotal {

            get { return this._precioTotal; }
            set { this._precioTotal = value; }
        
        }

        public PrecioEventArgs() : base() { 
        
        }

    }

}
