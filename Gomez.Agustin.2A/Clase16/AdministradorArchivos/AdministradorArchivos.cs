using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjercicioClase16
{
    static class AdministradorArchivos
    {
        public static bool Escribir(string path, string texto)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter stream = new StreamWriter(path, false))
                {
                    stream.Write(texto);
                    retorno = true;
                }
            }
            catch(Exception e)
            {

            }
            return retorno;
        }

        public static bool Leer(string path, out string texto)
        {
            bool retorno = false;
            texto = "";
            try
            {
                using (StreamReader stream = new StreamReader(path))
                {
                    texto = stream.ReadToEnd();
                    retorno = true;
                }
            }
            catch(Exception e)
            {
            }
            return retorno;
        }
    }
}
