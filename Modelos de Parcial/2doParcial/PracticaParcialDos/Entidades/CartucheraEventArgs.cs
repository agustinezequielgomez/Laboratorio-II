using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {

    public class CartucheraEventArgs : EventArgs {

        private string util;

        public string Util {

            get { return this.util; }
        
        }

        public CartucheraEventArgs(string objeto) {

            util = objeto;

        }

    }

}
