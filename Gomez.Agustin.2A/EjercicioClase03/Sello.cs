using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase03
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEncolor()
        {
            Console.BackgroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir()); //Encapsulamiento
        }

        private static string ArmarFormatoMensaje()
        {
            string cadenaReturn = "";
            string mensaje = "";
            if (TryParse(Sello.mensaje, out mensaje))
            {
                mensaje = Sello.mensaje;
                string asteriscos = "";
                string middleLine = "";
                int largo = mensaje.Length;
                int i;
                for (i = 0; i < largo + 2; i++)
                {
                    asteriscos += "*";
                }
                middleLine += "\n*";
                middleLine += mensaje;
                middleLine += "*\n";
                cadenaReturn += asteriscos;
                cadenaReturn += middleLine;
                cadenaReturn += asteriscos;
            }
            return cadenaReturn;
        }

        private static bool TryParse(string mensaje, out string cadena)
        {
            cadena = "";
            if(mensaje.Length==0)
            {
                return false;
            }
            else
            {
                return true;
                cadena = mensaje;
            }
        }
    }
}