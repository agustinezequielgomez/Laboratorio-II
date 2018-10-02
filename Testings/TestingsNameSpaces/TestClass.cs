using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingsNameSpaces
{
    sealed class Programo
    {
        public static int numero;
        public string cadena;
        public Programo()
        {
            cadena = "hola";
        }

        static Programo()
        {
            numero = 45;
        }
        
    }
}
