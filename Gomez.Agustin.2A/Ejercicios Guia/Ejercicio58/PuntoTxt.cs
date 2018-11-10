using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio58
{
    class PuntoTxt : Archivo,IArchivos<string>
    {

        #region Metodos
        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                if (base.ValidarArchivo(ruta))
                {
                    if (Path.GetExtension(ruta) == ".txt")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("\nEl archivo no es un txt.");
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("\nEl archivo no es un txt.", e);
            }
            return true;
        }

        public bool Guardar(string ruta, string obj)
        {
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                writer.Write(obj);
                return true;
            }
        }

        public string Leer(string ruta)
        {
            using (StreamReader reader = new StreamReader(ruta))
            {
                return reader.ReadToEnd();
            }
        }
        #endregion
    }
}
