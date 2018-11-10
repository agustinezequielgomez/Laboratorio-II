using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio54
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArchivoTexto.Leer("Archivo.txt");
            }
            catch(FileNotFoundException e)
            {
                ArchivoTexto.Guardar(String.Format(AppDomain.CurrentDomain.BaseDirectory + "{0:yyyyMMdd-HHmm}.txt", DateTime.Now), String.Format("Error: {0}\nArchivo no encontrado: {1}", e.Message, e.FileName));
            }

            Console.WriteLine(ArchivoTexto.Leer(String.Format(AppDomain.CurrentDomain.BaseDirectory + "{0:yyyyMMdd-HHmm}.txt", DateTime.Now)));
            Console.ReadKey();
        }
    }
}
