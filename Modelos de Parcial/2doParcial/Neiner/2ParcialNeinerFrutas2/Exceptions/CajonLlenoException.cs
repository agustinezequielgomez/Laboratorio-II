using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions {

    public class CajonLlenoException : Exception {

        public CajonLlenoException(string message) : base(message) { 
        
        }

    }

}
