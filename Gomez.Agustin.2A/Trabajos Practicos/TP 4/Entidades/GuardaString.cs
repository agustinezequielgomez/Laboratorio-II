using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\"+archivo, true))
                {
                    writer.WriteLine(texto);
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
