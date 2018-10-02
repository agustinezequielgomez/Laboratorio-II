using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace OtraLibreria
{
    public class Ordenador
    {
        public int OrdenarPersonasPorDni(Persona a, Persona b)
        {
            int retorno = 0;

            if (a.DNI > b.DNI)
            {
                retorno = 1;
            }
            if (a.DNI < b.DNI)
            {
                retorno = -1;
            }

            return retorno;
        }
    }
}
