using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    public delegate void HilosDelegate(string mensaje);
    public class LosHilos : IRespuesta<int>
    {
        int _id;
        List<InfoHilo> _misHilos;

        public string Bitacora
        {
            get
            {
                try
                {
                    if (File.Exists("bitacora.txt"))
                    {
                        StreamReader archivo_leido = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + " //bitacora.txt");
                        
                        string file_content = archivo_leido.ReadToEnd();
                        archivo_leido.Close();
                        return file_content;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            set
            {
                try
                {
                    StreamWriter nuevo_archivo = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//bitacora.txt");
                    nuevo_archivo.WriteLine(value);
                    nuevo_archivo.Close();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        public LosHilos()
        {
            this._id = 0;
            this._misHilos = new List<InfoHilo>();
        }

        static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos._id++;
            InfoHilo nuevo_hilo = new InfoHilo(hilos._id, hilos);
            hilos._misHilos.Add(nuevo_hilo);
            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Terminó el hilo {0}.", id);
            string mensaje = sb.ToString();
            this.Bitacora = mensaje;
            AvisoFin.Invoke(mensaje);
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad > 1)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    hilos = LosHilos.AgregarHilo(hilos);
                }
                return hilos;
            }
            else
            {
                throw new CantidadInvalidaException();
            }
        }

        public event HilosDelegate AvisoFin;
    }
}
