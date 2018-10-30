using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase16
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\Archivo.txt");
            string path2 = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Archivo.txt");
            string path3 = (Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Archivo.txt");
            string pathBase = (AppDomain.CurrentDomain.BaseDirectory) + @"\Archivo.txt";
            string texto;
            AdministradorArchivos.Escribir(path1, "\nEscritorio");
            if(AdministradorArchivos.Leer(path1, out texto))
            {
                Console.WriteLine(texto);
            }
            AdministradorArchivos.Escribir(path2, "\nDocumentos");
            if (AdministradorArchivos.Leer(path2, out texto))
            {
                Console.WriteLine(texto);
            }
            AdministradorArchivos.Escribir(path3, "\nImagenes");
            if (AdministradorArchivos.Leer(path3, out texto))
            {
                Console.WriteLine(texto);
            }
            AdministradorArchivos.Escribir(pathBase, "\nBase");
            if (AdministradorArchivos.Leer(pathBase, out texto))
            {
                Console.WriteLine(texto);
            }
            Console.ReadKey();
        }
    }
}
