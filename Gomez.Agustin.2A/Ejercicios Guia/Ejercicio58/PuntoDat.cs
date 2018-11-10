using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio58
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        #region Atributos
        private string contenido;
        #endregion

        #region Propiedades
        public string Contenido
        {
            get
            {
                return this.contenido;
            }

            set
            {
                this.contenido = value;
            }
        }

        #endregion
        public PuntoDat()
        {
        }

        #region Metodos
        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                if (base.ValidarArchivo(ruta))
                {
                    if (Path.GetExtension(ruta) == ".dat")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("\nEl archivo no es un dat");
                    }
                }
            }
            catch(FileNotFoundException e)
            {
                throw new ArchivoIncorrectoException("\nEl archivo no es un dat.", e);
            }
            return true;
        }

        public bool Guardar(string ruta, PuntoDat obj)
        {
            using (FileStream stream = new FileStream(ruta,FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return true;
            }
        }

        public PuntoDat Leer(string ruta)
        {
            using (FileStream stream = new FileStream(ruta, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (PuntoDat)formatter.Deserialize(stream);
            }
        }
        #endregion
    }
}
