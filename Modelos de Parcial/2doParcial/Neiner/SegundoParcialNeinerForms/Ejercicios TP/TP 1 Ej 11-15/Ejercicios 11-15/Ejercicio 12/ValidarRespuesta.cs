using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            bool devolver = false;
            string respuesta;
            respuesta = Console.ReadLine();
            while(respuesta!="S" && respuesta!="N")
            {
                Console.WriteLine("Error, reingrese: ");
                respuesta = Console.ReadLine();
            }
            if(respuesta=="S")
            {
                devolver = true;
            }
            return devolver;
        }
    }
}
